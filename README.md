# RedEye

RedEye is a cohesive Sublime Text color scheme prioritizing readability. Inspired by flight instruments and [jetliner cockpits](https://duckduckgo.com/?t=ffab&q=cockpit+at+night&iax=images&ia=images), the color palette and contrast balance was chosen to minimize eye strain and remain clear in all lighting conditions.


![Color Scheme Preview](https://raw.githubusercontent.com/mattmag/RedEye/main/screenshots/brownfox.png)


## Design Goals

- **A Single Scheme for Day and Night**

    Color choices and contrast between background and foreground were tuned over multiple days and nights (and across multiple monitors) in an attempt at becoming more than just a "dark theme".

- **Logical Color Groupings**

    Why can't reading code be similar to reading a nicely formatted text document? Like headers and paragraphs, we have classes and method definitions, and while we can't make use of type face and scale, we can make better use of a scheme's only tool: color. In RedEye colors are used to accentuate the code's natural hierarchy.
  
    <sub>Note how easy it is to identify classes and methods in the file and the minimap</sub>

    ![Code Hierarchy](https://raw.githubusercontent.com/mattmag/RedEye/main/screenshots/scrolling.gif)

- **Subtle Variations**

    For major code blocks, RedEye avoids vomiting the rainbow into your eyes, yet it doesn't resort to unhelpful monochromatic text either.  Subtle variations in the base color provide just enough contrast to distinguish between in line operations.

- **Faded Comments with XML Comments Support**

    Comments are faint to avoid pulling focus from the code. As large comment blocks usually precede method and class definitions, their style furthers the goal of visually separating major code structures. 


## Language Support

- C# - Originally created for C# (see above screenshots)
- Rust - Some rust specific tuning

    ![Rust Screenshot](https://raw.githubusercontent.com/mattmag/RedEye/main/screenshots/rust.png)
    
- JSON - Adjusted to keep dominant colors consistent across languages (instead of defaulting to the string color)

    ![JSON Screenshot](https://raw.githubusercontent.com/mattmag/RedEye/main/screenshots/json.png)
    
- XML - Basic Support

    ![XML Screenshot](https://raw.githubusercontent.com/mattmag/RedEye/main/screenshots/xml.png)

- Markdown

    ![Markdown Screenshot](https://raw.githubusercontent.com/mattmag/RedEye/main/screenshots/markdown.png)


## Installation

Method 1: Package Control (Recommended)

1. In Sublime Text, Hit Ctrl + Shift + P to bring up the command palette
2. Type Install Package and hit Enter
3. Type RedEye (one word) and select it from the list


Method 2: Manual Installation

1. Get the theme either by downloading and extracting a release from the right, downloading the RedEye.sublime-color-scheme file from the source files above, or cloning this repository to your PC.
2. In Sublime Text, go to Preferences > Browse Packages
3. Create a RedEye sub folder at the packages location (or organize them anyway you like)
4. Add the RedEye.sublime-color-scheme file to the sub folder


## License and Contribution

Style and contents licensed under Attribution-NonCommercial-ShareAlike 4.0 International [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/). Derivations should credit mattmag and link back to this repository.

If you wish to help tune the scheme towards a programming language that is currently not well supported, feel free to make the changes and create a pull request.


## Thanks

Shout out to the [ColorSchemeEditor](https://packagecontrol.io/packages/ColorSchemeEditor) and [ScopeHunter](https://packagecontrol.io/packages/ScopeHunter) plugins for making color scheme editing easier.
