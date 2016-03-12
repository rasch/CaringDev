---
layout: post
title: "An application of structural typing"
subtitle: "Accessing XML data using the F# XML type provider"
date: 2016-02-21 
---
At some point you'll find yourself doing [ETL](https://en.wikipedia.org/wiki/Extract,_transform,_load "Extract, Transform, Load").
Usually this is rather boring and tedious work. Unless...

Recently, our team was tasked with repeatedly loading a few GBs of XML into SQL Server.
For reasons beyond this post we didn't want to use the built-in XML functionality but decided to use F#.
Specifically, we used the [XML provider](http://fsharp.github.io/FSharp.Data/library/XmlProvider.html) for the extract step and the [SQL provider](http://fsprojects.github.io/SQLProvider/) for loading into a handcrafted database.

Extraction and loading was done in no time. But I was concerned about seeing duplicated code for extracting potentially nillable, optional values.
The sample XML is similar to the following, simplified one:
{% highlight xml %}
<?xml version="1.0" encoding="UTF-8" ?>
<roots xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <root>
    <Available>Foo</Available>
    <Nil xsi:nil="true"/>
    <Missing>42</Missing>
    <Missing_Nil>1337</Missing_Nil>
  </root>
  <root>
    <Available>Bar</Available>
    <Nil>3.141</Nil>
  </root>
  <root>
    <Available></Available>
    <Nil>2.718</Nil>
    <Missing_Nil xsi:nil="true"/>
  </root>
</roots>
{% endhighlight %}

The XML type provider is then configured and a file (containing only one `root` element) loaded as follows:
{% highlight fsharp %}
type Sample = XmlProvider<"sample.xml", SampleIsList=true, Global=true, InferTypesFromValues=true>
let root = Sample.Load("file.xml")
{% endhighlight %}

The loaded data should be stored in a record suitable for sending to the database ...
{% highlight fsharp %}
type Record = {
    Available : string
    Missing : string
    Nil : Nullable<decimal>
    MissingNil : Nullable<int>
}
{% endhighlight %}
... but the type provider generates types equivalent to the following ones:
{% highlight fsharp %}
type Root = {
    Available : string
    Missing : string option
    Nil : Nil
    MissingNil : MissingNil option
}
 
and Nil = {
    Nil : bool option
    Value : decimal
}
 
and MissingNil = {
    Nil : bool option
    Value : int
}
{% endhighlight %}
