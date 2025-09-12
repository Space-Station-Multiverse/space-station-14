This is the Space Station Multiverse vanilla server content.

This repo closely aligns with WizDen's Space Station 14 repo but has been modified to use MV's Auth system.

If you plan to use this as your upstream, choose one of the "example vanilla content" forks listed on the [MV engine page](https://spacestationmultiverse.com/mv-engine/).

Please also see [How to switch to MV Engine](https://spacestationmultiverse.com/mv-engine/how-to-switch-to-mv-engine/)

## Building

1. Clone this repo:
```shell
git clone https://github.com/space-wizards/space-station-14.git
```
2. Go to the project folder and run `RUN_THIS.py` to initialize the submodules and load the engine:
```shell
cd space-station-14
python RUN_THIS.py
```
3. Compile the solution:

Build the server using `dotnet build`.

WizDen has a guide on how to build SS14 that may be useful [here](https://docs.spacestation14.com/en/general-development/setup.html)

## License

All code for the content repository is licensed under the [MIT license](https://github.com/space-wizards/space-station-14/blob/master/LICENSE.TXT).

Most assets are licensed under [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) unless stated otherwise. Assets have their license and copyright specified in the metadata file. For example, see the [metadata for a crowbar](https://github.com/space-wizards/space-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).

> [!NOTE]
> Some assets are licensed under the non-commercial [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) or similar non-commercial licenses and will need to be removed if you wish to use this project commercially.
