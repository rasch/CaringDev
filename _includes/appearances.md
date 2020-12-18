{% for a in site.data.appearances %}
{% assign kind = site.data.appearance-kind[a.kind] %}
{% capture icon %}<i class="fi-{{ kind.icon }} text-muted" title="{{ kind.desc }}"></i>{% endcapture %}
<div class="row row-striped">
<div class="col-10 col-md-2">{{ a.date | date_to_string }}</div>
<div class="d-md-none col-2 text-right">{{ icon }}</div>
{% if a.slideLink %}
<div class="col-12 col-md-9 col-lg-6"><a href="{{ a.slideLink }}" rel="noopener noreferrer" target="_blank">{{ a.title }}</a></div>
{% else %}
<div class="col-12 col-md-9 col-lg-6">{{ a.title }}</div>
{% endif %}
<div class="d-none d-md-block d-lg-none col-1 text-right">{{ icon }}</div>
{% if a.venueLink %}
<div class="col-12 offset-md-2 col-md-10 offset-lg-0 col-lg-3"><a href="{{ a.venueLink }}" target="_blank">{{ a.venue }}</a></div>
{% else %}
<div class="col-12 offset-md-2 col-md-10 offset-lg-0 col-lg-3">{{ a.venue }}</div>
{% endif %}
<div class="d-none d-lg-block col-1 text-right">{{ icon }}</div>
</div>
{% endfor %}