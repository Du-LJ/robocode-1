/**
 * Copyright (c) 2001-2020 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * https://robocode.sourceforge.io/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.host {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IHostManager {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void cleanup();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;Lnet/sf/robocode/host/RobotStatics;Lnet/sf/" +
            "robocode/peer/IRobotPeer;)Ljava/lang/Object;")]
        global::java.lang.Object createRobotProxy(global::java.lang.Object par0, global::java.lang.Object par1, global::net.sf.robocode.peer.IRobotPeer par2);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;")]
        java.lang.String[] getReferencedClasses(global::net.sf.robocode.repository.IRobotItem par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;" +
            "")]
        global::net.sf.robocode.repository.RobotType getRobotType(global::net.sf.robocode.repository.IRobotItem par0, bool par1, bool par2);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void initSecurity();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        long getRobotFilesystemQuota();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void resetThreadManager();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Thread;)V")]
        void addSafeThread(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Thread;)V")]
        void removeSafeThread(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/PrintStream;")]
        global::java.io.PrintStream getRobotOutputStream();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IHostManager_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.host.@__IHostManager.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.robocode.host.IHostManager), typeof(global::net.sf.robocode.host.IHostManager_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.robocode.host.IHostManager), typeof(global::net.sf.robocode.host.IHostManager_))]
    internal sealed partial class @__IHostManager : global::java.lang.Object, global::net.sf.robocode.host.IHostManager {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_cleanup0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createRobotProxy1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getReferencedClasses2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobotType3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_initSecurity4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobotFilesystemQuota5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_resetThreadManager6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_addSafeThread7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_removeSafeThread8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobotOutputStream9;
        
        private @__IHostManager(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.host.@__IHostManager.staticClass = @__class;
            global::net.sf.robocode.host.@__IHostManager.j4n_cleanup0 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "cleanup", "()V");
            global::net.sf.robocode.host.@__IHostManager.j4n_createRobotProxy1 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "createRobotProxy", "(Lrobocode/control/RobotSpecification;Lnet/sf/robocode/host/RobotStatics;Lnet/sf/" +
                    "robocode/peer/IRobotPeer;)Ljava/lang/Object;");
            global::net.sf.robocode.host.@__IHostManager.j4n_getReferencedClasses2 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "getReferencedClasses", "(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;");
            global::net.sf.robocode.host.@__IHostManager.j4n_getRobotType3 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "getRobotType", "(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;" +
                    "");
            global::net.sf.robocode.host.@__IHostManager.j4n_initSecurity4 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "initSecurity", "()V");
            global::net.sf.robocode.host.@__IHostManager.j4n_getRobotFilesystemQuota5 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "getRobotFilesystemQuota", "()J");
            global::net.sf.robocode.host.@__IHostManager.j4n_resetThreadManager6 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "resetThreadManager", "()V");
            global::net.sf.robocode.host.@__IHostManager.j4n_addSafeThread7 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "addSafeThread", "(Ljava/lang/Thread;)V");
            global::net.sf.robocode.host.@__IHostManager.j4n_removeSafeThread8 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "removeSafeThread", "(Ljava/lang/Thread;)V");
            global::net.sf.robocode.host.@__IHostManager.j4n_getRobotOutputStream9 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHostManager.staticClass, "getRobotOutputStream", "()Ljava/io/PrintStream;");
        }
        
        public void cleanup() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.@__IHostManager.j4n_cleanup0);
            }
        }
        
        public global::java.lang.Object createRobotProxy(global::java.lang.Object par0, global::java.lang.Object par1, global::net.sf.robocode.peer.IRobotPeer par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHostManager.j4n_createRobotProxy1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.peer.IRobotPeer>(@__env, par2)));
            }
        }
        
        public java.lang.String[] getReferencedClasses(global::net.sf.robocode.repository.IRobotItem par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHostManager.j4n_getReferencedClasses2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.repository.IRobotItem>(@__env, par0)));
            }
        }
        
        public global::net.sf.robocode.repository.RobotType getRobotType(global::net.sf.robocode.repository.IRobotItem par0, bool par1, bool par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::net.sf.robocode.repository.RobotType>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHostManager.j4n_getRobotType3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.repository.IRobotItem>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
            }
        }
        
        public void initSecurity() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.@__IHostManager.j4n_initSecurity4);
            }
        }
        
        public long getRobotFilesystemQuota() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::net.sf.robocode.host.@__IHostManager.j4n_getRobotFilesystemQuota5)));
            }
        }
        
        public void resetThreadManager() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.@__IHostManager.j4n_resetThreadManager6);
            }
        }
        
        public void addSafeThread(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.@__IHostManager.j4n_addSafeThread7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void removeSafeThread(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.@__IHostManager.j4n_removeSafeThread8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public global::java.io.PrintStream getRobotOutputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.PrintStream>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHostManager.j4n_getRobotOutputStream9));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IHostManager);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "cleanup", "cleanup0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "createRobotProxy", "createRobotProxy1", "(Lrobocode/control/RobotSpecification;Lnet/sf/robocode/host/RobotStatics;Lnet/sf/" +
                        "robocode/peer/IRobotPeer;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReferencedClasses", "getReferencedClasses2", "(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRobotType", "getRobotType3", "(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;" +
                        ""));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "initSecurity", "initSecurity4", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRobotFilesystemQuota", "getRobotFilesystemQuota5", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "resetThreadManager", "resetThreadManager6", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addSafeThread", "addSafeThread7", "(Ljava/lang/Thread;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeSafeThread", "removeSafeThread8", "(Ljava/lang/Thread;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRobotOutputStream", "getRobotOutputStream9", "()Ljava/io/PrintStream;"));
            return methods;
        }
        
        private static void cleanup0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__real.cleanup();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle createRobotProxy1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1, global::net.sf.jni4net.utils.JniLocalHandle par2) {
            // (Lrobocode/control/RobotSpecification;Lnet/sf/robocode/host/RobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Ljava/lang/Object;
            // (Ljava/lang/Object;Ljava/lang/Object;Lnet/sf/robocode/peer/IRobotPeer;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.createRobotProxy(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par1), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, par2)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getReferencedClasses2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;
            // (Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongCp2J(@__env, @__real.getReferencedClasses(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.repository.IRobotItem>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getRobotType3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, bool par1, bool par2) {
            // (Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;
            // (Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getRobotType(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.repository.IRobotItem>(@__env, par0), par1, par2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void initSecurity4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__real.initSecurity();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static long getRobotFilesystemQuota5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__return = ((long)(@__real.getRobotFilesystemQuota()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void resetThreadManager6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__real.resetThreadManager();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void addSafeThread7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Thread;)V
            // (Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__real.addSafeThread(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeSafeThread8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Thread;)V
            // (Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__real.removeSafeThread(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getRobotOutputStream9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/PrintStream;
            // ()Ljava/io/PrintStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHostManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getRobotOutputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.host.@__IHostManager(@__env);
            }
        }
    }
    #endregion
}
