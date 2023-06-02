# Unity Game Control Customization

This repository provides two essential scripts for a Unity game that empowers players to personalize their controls. The scripts are `ControlSetter.cs` and `GameSettings.cs`. They are engineered to handle user input for key binding, save these settings, and make them available for future gaming sessions.

## CustomControls.cs

`CustomControls.cs` is designed to facilitate the user's control customization process. It contains a GUI which not only displays the currently assigned keys, but also offers the option for the user to modify these assignments. Upon a control selection for change by the user, it transitions into a 'listening' mode. Here, it waits for the next user key press and assigns the newly pressed key as the new control.

## GameSettings.cs

`GameSettings.cs`, on the other hand, is responsible for the persistence of the customized controls. It uses a binary formatter that serializes the control settings into a binary file. This file is stored in the persistent data path provided by Unity. The script checks for the existence of the controls file on game startup. If the file exists, it reads and applies the settings. If not, it writes the default settings to a new file. This script also retrieves the difficulty setting from the player preferences.

## Contribution

Contributions are welcome. Please fork this repository and open a pull request to add more scripts or fix any issues.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
