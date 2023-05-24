using System;

public class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.BaseType == baseType && derivedType != baseType)
            return true;
        else
            return false;
    }
}