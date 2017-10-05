---
layout: default
title: About
---
# Caring Dev <small>caring (not only) about code</small>

Pathologically obsessed with code quality. \\
Functional language admirer, Meetup-participant, broken English freshman blogger, DIY injector, fireman, volleyball player, motorcyclist, …

Professionally writing C#, F#, JavaScript, TypeScript (past: Scala, C++, Java, Delphi) using AngularJS, WebAPI, xUnit, xBehave, … \\
Knows some (T-)SQL, HTML, CSS, XML, JSON, … \\
Played with Oberon, Eiffel, (Turbo)Pascal, (V)Basic, OCaml, Coq, Haskell.

## Appearances

{% for a in site.data.appearances %}
<div class="row">
<div class="col-xs-12 col-sm-2 col-lg-2">{{ a.date | date_to_string }}</div>
<div class="col-xs-12 col-sm-10 col-lg-4">{{ a.title }}</div>
{% if a.venueLink %}
<div class="col-xs-12 col-sm-offset-2 col-lg-offset-0 col-sm-10 col-lg-5"><a href="{{ a.venueLink }}">{{ a.venue }}</a></div>
{% else %}
<div class="col-xs-12 col-sm-offset-2 col-lg-offset-0 col-sm-10 col-lg-5">{{ a.venue }}</div>
{% endif %}
{% if a.slideLink %}
<div class="col-xs-12 col-sm-offset-2 col-lg-offset-0 col-sm-10 col-lg-1"><a href="{{ a.slideLink }}" rel="noopener noreferrer" target="_blank">Slides</a></div>
{% endif %}
<div class="visible-xs-block col-xs-12">&nbsp;</div>
</div>
{% endfor %}

## Find me on

<a href="http://stackexchange.com/users/3455728">
<img src="http://stackexchange.com/users/flair/3455728.png?theme=clean" width="208" height="58" alt="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites" title="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites">
</a>

<a href="https://twitter.com/_Caring_Dev_?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-size="large" data-dnt="true" data-show-count="false">@_Caring_Dev_</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>