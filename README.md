FerretLib.WinForms
=============

WinForms controls, helpers etc.

Will gradually move relevant code from individual projects to here. Current requirement is .Net Framework 3.5. I'll try to keep requirements to a minimum but can't see it going any lower than 3.5.

**UPDATE**: now available as a Nuget package (27-Feb-2014). Will try to keep it updated but if you notice it significantly lagging behind the GitHub repo please let me know.

[![Send me a tweet](http://nathanchere.github.io/twitter_tweet.png)](https://twitter.com/intent/user?screen_name=nathanchere "Send me a tweet") [![Follow me](http://nathanchere.github.io/twitter_follow.png)](https://twitter.com/intent/user?screen_name=nathanchere "Follow me") [![Build status](https://ci-beta.appveyor.com/api/projects/status/ew99dvcd7yjfibf1)](https://ci-beta.appveyor.com/project/nathanchere/ferretlib-winforms)

Controls
--------

* **TagList**
A control intended for displaying and editing tag lists as commonly used for things like blog posts.
![](http://nathanchere.github.io/ferretlib_winforms_taglist.gif)

* **ResourceFontLoader**
Helper class for loading fonts embedded as resources in your .exe
*Currently broken because of a .Net Framework bug which has been reported and gone unfixed since .Net 2.0 - do not count on this working any time soon*

* **ColorPicker**
An alternative to the ColorDialog for choosing colours based on ARGB values.
![](http://nathanchere.github.io/ferretlib_winforms_colorpicker.gif)

----

**TODO**
* Configure allow duplicate tags
* Read-only mode (don't display tag input, process edit events etc)
* Autocomplete / tag suggestions
* More UI polish (hover effects, better transparency etc)
* Draw tags from scratch (minimal/no bitmap resources)
* Look and feel customisation (font, size, colour etc)
* Alternate colour format support (eg HSL)