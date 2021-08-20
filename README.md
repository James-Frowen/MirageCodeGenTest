# MirageCodeGenTest

Example of running ILPostprocessor on asmdef it also depends on.

### To Test

`MyCoreClass` and `MyOtherClass` both have a method that returns 0, but the ILPostprocessor will change this to the current time.

Add `MyCoreClass` and `MyOtherClass` to Gameobject and their onValdiate method should log the value. If it is 0 then the ILPostprocessor failed.

