# RedEye
RedEye is a cohesive color Sublime Text scheme prioritizing readability. Inspired by flight instruments and [jet liner cockpits](https://duckduckgo.com/?t=ffab&q=cockpit+at+night&iax=images&ia=images), the color palette and contrast balance was chosen to minimize eye strain and remain clear in all lighting conditions.


![Color Scheme Preview](https://github.com/mattmag/RedEye/blob/main/screenshots/brownfox.png?raw=true "Color Scheme Preview")


## Design Goals
- **A Single Scheme for Day and Night**\
    Color choices and contrast between background and foreground were tuned over multiple days and nights and across multiple monitors in an attempt at becoming more than just a "dark theme" - so leave those blinds open to get your Vitamin D or turn that dimmer all the way down to set the mood.

- **Logical Color Groupings**\
    Why can't reading code be similar to reading a nicely formatted document? Instead of headers and paragraphs, we have classes and method definitions. And while we can't make use of type face and scale, we can make better use a scheme's only tool: color. In RedEye colors are used to accentuate the code's natural hierarchy.
  
    <sub>Note how easy it is to identify classes and methods in the file and the minimap</sub>\
    ![Code Hierarchy](https://github.com/mattmag/RedEye/blob/main/screenshots/scrolling.gif?raw=true "Code Hierarchy")

- **Subtle Variations**\
    For major code blocks, RedEye avoids vomiting the rainbow into your eyes, and doesn't resort to unhelpful monochromatic text.  Subtle variations in the base color provide just enough contrast to distinguish between in line operations.

- **Faded Comments with XML Comments Support**\
    Comments are faint to avoid pulling focus from the code. As large comment blocks usually precede method and class definitions, their style furthers the goal of visually separating major code structures.  Also, C#'s XML comments are supported to help aid with formatting and syntax.


## Language Support
- C# - Originally created for C# (see above screenshots)
- Rust - Some rust specific tuning\
    ![Rust Screenshot](https://github.com/mattmag/RedEye/blob/main/screenshots/rust.png?raw=true "Rust Screenshot")
- JSON - Adjusted to keep dominant colors consistent across languages (instead of defaulting to the string color)\
    ![JSON Screenshot](https://github.com/mattmag/RedEye/blob/main/screenshots/json.png?raw=true "JSON Screenshot")
- XML - Basic Support\
    ![XML Screenshot](https://github.com/mattmag/RedEye/blob/main/screenshots/xml.png?raw=true "XML Screenshot")

## License
Attribution-NonCommercial-ShareAlike 4.0 International [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/)

## Thanks

Shout out to the [ColorSchemeEditor](https://packagecontrol.io/packages/ColorSchemeEditor) and [ScopeHunter](https://packagecontrol.io/packages/ScopeHunter) plugins for making color scheme editing easier.