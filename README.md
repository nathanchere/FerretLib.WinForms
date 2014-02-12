FerretLib.WinForms
=============

WinForms controls, helpers etc.

Will gradually move relevant code from individual projects to here.

* TagList
A control intended for displaying and editing tag lists as commonly used for things like blog posts.
![](http://nathanchere.github.io/ferretlib_winforms_taglist.gif)

* ResourceFontLoader
Helper class for loading fonts embedded as resources

Current requirement is .Net Framework 3.5. I'll try to keep requirements to a minimum but can't see it going any lower than 3.5.

TODO:

* Allow duplicate tags
* Read-only mode (don't display tag input, process edit events etc)
* Autocomplete / tag suggestions
* More UI polish (hover effects, better transparency etc)
* Draw  tags from scratch (minimal/no bitmap resources)
* Look and feel customisation (font, size, colour etc)