---
layout: default
title: About
---
# Caring Dev <small>caring (not only) about code</small>

Pathologically obsessed with code quality. \\
Functional language admirer, Meetup-participant, broken English freshman blogger, DIY injector, fireman, volleyball player, motorcyclist, …

Professionally writing C#, F#, TypeScript, JavaScript (past: Scala, C++, Java, Delphi) \\
Using AngularJS, WebAPI, xUnit, xBehave, EF, Dapper, WCF, WF, … \\
Knows some (T-)SQL, HTML, CSS, XML, JSON, … \\
Played with Oberon, Eiffel, (Turbo)Pascal, (V)Basic, OCaml, Coq, Haskell.

## Appearances

{% for a in site.data.appearances %}
{% assign iconTitle = site.data.icons[a.icon] %}
<div class="row row-striped">
<div class="col-xs-12 col-sm-2 col-lg-2">{{ a.date | date_to_string }}</div>
{% if a.slideLink %}
<div class="col-xs-12 col-sm-9 col-lg-4"><a href="{{ a.slideLink }}" rel="noopener noreferrer" target="_blank">{{ a.title }}</a></div>
{% else %}
<div class="col-xs-12 col-sm-9 col-lg-4">{{ a.title }}</div>
{% endif %}
<div class="visible-sm-block visible-md-block col-sm-1 text-right"><i class="glyphicon glyphicon-{{ a.icon }}" title="{{ iconTitle.desc }}"></i></div>
{% if a.venueLink %}
<div class="col-xs-12 col-sm-offset-2 col-lg-offset-0 col-sm-10 col-lg-5"><a href="{{ a.venueLink }}">{{ a.venue }}</a></div>
{% else %}
<div class="col-xs-12 col-sm-offset-2 col-lg-offset-0 col-sm-10 col-lg-5">{{ a.venue }}</div>
{% endif %}
<div class="visible-lg-block col-lg-1 text-right"><i class="glyphicon glyphicon-{{ a.icon }}" title="{{ iconTitle.desc }}"></i></div>
<div class="visible-xs-block col-xs-12">&nbsp;</div>
</div>
{% endfor %}

## Find me on

<a href="https://stackexchange.com/users/3455728">
<img src="https://stackexchange.com/users/flair/3455728.png?theme=clean" width="208" height="58" alt="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites" title="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites">
</a>

<a href="https://twitter.com/_Caring_Dev_?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-size="large" data-dnt="true" data-show-count="false">@_Caring_Dev_</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>