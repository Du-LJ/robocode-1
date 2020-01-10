/**
 * Copyright (c) 2001-2020 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * https://robocode.sourceforge.io/license/epl-v10.html
 */
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.robocode.serialization;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ISerializableHelper_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return net.sf.robocode.serialization.ISerializableHelper_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.robocode.serialization.ISerializableHelper_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ISerializableHelper extends system.Object implements net.sf.robocode.serialization.ISerializableHelper {
    
    protected __ISerializableHelper(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/serialization/RbSerializer;Ljava/nio/ByteBuffer;Ljava/lang/Object;)V")
    public native void serialize(net.sf.robocode.serialization.RbSerializer par0, java.nio.ByteBuffer par1, java.lang.Object par2);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/serialization/RbSerializer;Ljava/nio/ByteBuffer;)Ljava/lang/Object;")
    public native java.lang.Object deserialize(net.sf.robocode.serialization.RbSerializer par0, java.nio.ByteBuffer par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/serialization/RbSerializer;Ljava/lang/Object;)I")
    public native int sizeOf(net.sf.robocode.serialization.RbSerializer par0, java.lang.Object par1);
}
//</generated-proxy>
