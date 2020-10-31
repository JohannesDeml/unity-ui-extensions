# Change Log

All notable changes to this examples project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/).

## 2019.5 (v2.3) - 2020-10-31

Since the move to UPM, the team have been able to react quicker and push out fixes a lot easier, without affecting previous installation (whilst still adhering to Unity's backwards compatibility pattern).  So it is with great news we announce this new release, faster that ever :D  (and thanks to UPM, easier to upgrade than ever).
Be sure to also check out the "Examples" option in the Package Manager window to import the samples to your project.

### Added

- New UI Knob example
- New Magnetic Infinite Scroll example
- New Accordion example

### Changed

- Drop down scene updated with programmatic examples

### Deprecated

None

### Fixed

None

> Although note, to use the new Unity Input system, you will need to update the Input System Modules on the "Event System" object.  Unity have provided a button for this.

### Removed

None

### Additional Notes

#### [Installation Instructions](https://bitbucket.org/UnityUIExtensions/unity-ui-extensions/wiki/GettingStarted)

As of Unity 2019, there are now two paths for getting access to the Unity UI Extensions project:

- Unity 2019 or higher
The recommended way to add the Unity UI Extensions project to your solution is to use the Unity package Manager. Simply use the Unity Package Manager to reference the project to install it

Alternatively, you can also use the pre-compiled Unity packages if you wish, however, UPM offers full versioning support to allow you to switch versions as you wish.

- Unity 2018 or lower
The pre-compiled Unity assets are the only solution for Unity 2018 or earlier due to the changes in the Unity UI framework in Unity made for 2019.
Either clone / download this repository to your machine and then copy the scripts in, or use the pre-packaged .UnityPackage for your version of Unity and import it as a custom package in to your project.

#### Upgrade Notes

Due to the restructure of the package to meet Unity's new package guidelines, we recommend **Deleting the current Unity UI Extensions** folder prior to importing the new package.

For Unity 2019 users using the new UPM deployment, be sure to delete the existing folder in your assets folder before adding the new package to avoid conflict.