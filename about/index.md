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
<div class="col-xs-12 col-sm-offset-2 col-lg-offset-0 col-sm-10 col-lg-6"><a href="{{ a.venueLink }}">{{ a.venue }}</a></div>
</div>
{% endfor %}

## Find me on

<a href="http://stackexchange.com/users/3455728">
<img src="http://stackexchange.com/users/flair/3455728.png?theme=clean" width="208" height="58" alt="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites" title="profile for CaringDev on Stack Exchange, a network of free, community-driven Q&amp;A sites">
</a>