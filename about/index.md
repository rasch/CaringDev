---
layout: default
title: About
---
# Caring Dev <small>caring (not only) about code</small>

Pathologically obsessed with code quality. \\
Functional language admirer, Meetup-participant, broken English freshman blogger, DIY injector, fireman, volleyball player, motorcyclist, …

Professionally writing C#, F#, TypeScript, JavaScript (past: Scala, C++, Java, Delphi) \\
Using Angular, React, ASP.NET Core, WebAPI, xUnit, xBehave, EF, Dapper, WCF, WF, … \\
Knows some (T-)SQL, HTML, CSS, XML, JSON, … \\
Played with Oberon, Eiffel, (Turbo)Pascal, (V)Basic, OCaml, Coq, Haskell.

## Appearances

{% for a in site.data.appearances %}
{% assign iconTitle = site.data.icons[a.icon] %}
<div class="row row-striped">
<div class="col-11 col-md-2">{{ a.date | date_to_string }}</div>
<div class="d-md-none col-1 text-right"><i class="fi-{{ a.icon }}" title="{{ iconTitle.desc }}"></i></div>
{% if a.slideLink %}
<div class="col-12 col-md-9 col-lg-6"><a href="{{ a.slideLink }}" rel="noopener noreferrer" target="_blank">{{ a.title }}</a></div>
{% else %}
<div class="col-12 col-md-9 col-lg-6">{{ a.title }}</div>
{% endif %}
<div class="d-none d-md-block d-lg-none col-1 text-right"><i class="fi-{{ a.icon }}" title="{{ iconTitle.desc }}"></i></div>
{% if a.venueLink %}
<div class="col-12 offset-md-2 col-md-10 offset-lg-0 col-lg-3"><a href="{{ a.venueLink }}" target="_blank">{{ a.venue }}</a></div>
{% else %}
<div class="col-12 offset-md-2 col-md-10 offset-lg-0 col-lg-3">{{ a.venue }}</div>
{% endif %}
<div class="d-none d-lg-block col-1 text-right"><i class="fi-{{ a.icon }}" title="{{ iconTitle.desc }}"></i></div>
</div>
{% endfor %}
<p></p>

## Find me on

<a href="https://stackexchange.com/users/3455728" target="_blank">
<img src="https://stackexchange.com/users/flair/3455728.png?theme=clean" width="208" height="58" alt="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites" title="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites">
</a>

<a href="https://twitter.com/_Caring_Dev_?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-size="large" data-dnt="true" data-show-count="false">@_Caring_Dev_</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>