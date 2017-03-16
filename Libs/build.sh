## Instructions extracted from here : http://stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries

framework='Hero'
sdk='iphoneos10.2'

### -----------------------------------------
### GENERATE FAT LIBRARY
### -----------------------------------------

## Delete old output
rm -rf output
mkdir output

## Copy framework
cp -rf input/Release-iphonesimulator/$framework.framework output/$framework.framework

## Build
lipo -create input/Release-iphonesimulator/$framework.framework/$framework input/Release-iphoneos/$framework.framework/$framework -output output/$framework.framework/$framework

## Copy result to output
cp -rf input/Release-iphoneos/$framework.framework/Modules/$framework.swiftmodule output/$framework.framework/Modules/$framework.swiftmodule

### -----------------------------------------
### GENERATE API DEFINITION
### -----------------------------------------

cp output/$framework.framework/Headers/$framework-Swift.h output/$framework-Swift.h
sharpie bind -sdk $sdk output/$framework-Swift.h -o output
