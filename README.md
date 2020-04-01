# dcm2jpeg
Javascript DICOM to JPEG base64 image, use fo-dicom c# dll with Edge-js 

Using edge-js to call c# DLL to convert DICOM file to JPEG image.

Tested on Windows 10 (64bit) https://github.com/hashtafak/dcm2jpeg/blob/master/dcm2jpeg-x64.js

# Require for DLL (same as edge-js)
+ Latest vcredit
+ .NET Framework 4.5.2

Supported All Transfer Syntaxes (Windows Only): https://github.com/fo-dicom/fo-dicom/wiki/Supported-Transfer-Syntaxes

Linux/MacOS version not available.

Working on Linux/MacOS with Pydicom: https://github.com/pydicom/pydicom

Note that edge have edge-py, run python in NodeJS https://github.com/tjanczuk/edge#how-to-script-python-in-a-nodejs-application

Other solutions C/C++: GDCM, DCMTK
