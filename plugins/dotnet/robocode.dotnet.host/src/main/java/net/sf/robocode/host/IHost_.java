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

package net.sf.robocode.host;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class IHost_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return net.sf.robocode.host.IHost_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.robocode.host.IHost_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __IHost extends system.Object implements net.sf.robocode.host.IHost {
    
    protected __IHost(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/host/IHostManager;Ljava/lang/Object;Lnet/sf/robocode/peer/IRobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Lnet/sf/robocode/host/proxies/IHostingRobotProxy;")
    public native net.sf.robocode.host.proxies.IHostingRobotProxy createRobotProxy(net.sf.robocode.host.IHostManager par0, robocode.control.RobotSpecification par1, net.sf.robocode.peer.IRobotStatics par2, net.sf.robocode.peer.IRobotPeer par3);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;")
    public native java.lang.String[] getReferencedClasses(net.sf.robocode.repository.IRobotItem par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;")
    public native net.sf.robocode.repository.RobotType getRobotType(net.sf.robocode.repository.IRobotItem par0, boolean par1, boolean par2);
}
//</generated-proxy>
