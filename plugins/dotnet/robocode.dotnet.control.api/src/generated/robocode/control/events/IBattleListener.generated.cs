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

namespace robocode.control.events {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IBattleListener {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattleStartedEvent;)V")]
        void onBattleStarted(global::robocode.control.events.BattleStartedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattleFinishedEvent;)V")]
        void onBattleFinished(global::robocode.control.events.BattleFinishedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattleCompletedEvent;)V")]
        void onBattleCompleted(global::robocode.control.events.BattleCompletedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattlePausedEvent;)V")]
        void onBattlePaused(global::robocode.control.events.BattlePausedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattleResumedEvent;)V")]
        void onBattleResumed(global::robocode.control.events.BattleResumedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/RoundStartedEvent;)V")]
        void onRoundStarted(global::robocode.control.events.RoundStartedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/RoundEndedEvent;)V")]
        void onRoundEnded(global::robocode.control.events.RoundEndedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/TurnStartedEvent;)V")]
        void onTurnStarted(global::robocode.control.events.TurnStartedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/TurnEndedEvent;)V")]
        void onTurnEnded(global::robocode.control.events.TurnEndedEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattleMessageEvent;)V")]
        void onBattleMessage(global::robocode.control.events.BattleMessageEvent par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/BattleErrorEvent;)V")]
        void onBattleError(global::robocode.control.events.BattleErrorEvent par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IBattleListener_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.events.@__IBattleListener.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::robocode.control.events.IBattleListener), typeof(global::robocode.control.events.IBattleListener_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::robocode.control.events.IBattleListener), typeof(global::robocode.control.events.IBattleListener_))]
    internal sealed partial class @__IBattleListener : global::java.lang.Object, global::robocode.control.events.IBattleListener {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattleStarted0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattleFinished1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattleCompleted2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattlePaused3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattleResumed4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onRoundStarted5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onRoundEnded6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onTurnStarted7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onTurnEnded8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattleMessage9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onBattleError10;
        
        private @__IBattleListener(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.events.@__IBattleListener.staticClass = @__class;
            global::robocode.control.events.@__IBattleListener.j4n_onBattleStarted0 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattleStarted", "(Lrobocode/control/events/BattleStartedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onBattleFinished1 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattleFinished", "(Lrobocode/control/events/BattleFinishedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onBattleCompleted2 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattleCompleted", "(Lrobocode/control/events/BattleCompletedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onBattlePaused3 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattlePaused", "(Lrobocode/control/events/BattlePausedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onBattleResumed4 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattleResumed", "(Lrobocode/control/events/BattleResumedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onRoundStarted5 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onRoundStarted", "(Lrobocode/control/events/RoundStartedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onRoundEnded6 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onRoundEnded", "(Lrobocode/control/events/RoundEndedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onTurnStarted7 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onTurnStarted", "(Lrobocode/control/events/TurnStartedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onTurnEnded8 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onTurnEnded", "(Lrobocode/control/events/TurnEndedEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onBattleMessage9 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattleMessage", "(Lrobocode/control/events/BattleMessageEvent;)V");
            global::robocode.control.events.@__IBattleListener.j4n_onBattleError10 = @__env.GetMethodID(global::robocode.control.events.@__IBattleListener.staticClass, "onBattleError", "(Lrobocode/control/events/BattleErrorEvent;)V");
        }
        
        public void onBattleStarted(global::robocode.control.events.BattleStartedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattleStarted0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onBattleFinished(global::robocode.control.events.BattleFinishedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattleFinished1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onBattleCompleted(global::robocode.control.events.BattleCompletedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattleCompleted2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onBattlePaused(global::robocode.control.events.BattlePausedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattlePaused3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onBattleResumed(global::robocode.control.events.BattleResumedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattleResumed4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onRoundStarted(global::robocode.control.events.RoundStartedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onRoundStarted5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onRoundEnded(global::robocode.control.events.RoundEndedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onRoundEnded6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onTurnStarted(global::robocode.control.events.TurnStartedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onTurnStarted7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onTurnEnded(global::robocode.control.events.TurnEndedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onTurnEnded8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onBattleMessage(global::robocode.control.events.BattleMessageEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattleMessage9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void onBattleError(global::robocode.control.events.BattleErrorEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.events.@__IBattleListener.j4n_onBattleError10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IBattleListener);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattleStarted", "onBattleStarted0", "(Lrobocode/control/events/BattleStartedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattleFinished", "onBattleFinished1", "(Lrobocode/control/events/BattleFinishedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattleCompleted", "onBattleCompleted2", "(Lrobocode/control/events/BattleCompletedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattlePaused", "onBattlePaused3", "(Lrobocode/control/events/BattlePausedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattleResumed", "onBattleResumed4", "(Lrobocode/control/events/BattleResumedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onRoundStarted", "onRoundStarted5", "(Lrobocode/control/events/RoundStartedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onRoundEnded", "onRoundEnded6", "(Lrobocode/control/events/RoundEndedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onTurnStarted", "onTurnStarted7", "(Lrobocode/control/events/TurnStartedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onTurnEnded", "onTurnEnded8", "(Lrobocode/control/events/TurnEndedEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattleMessage", "onBattleMessage9", "(Lrobocode/control/events/BattleMessageEvent;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onBattleError", "onBattleError10", "(Lrobocode/control/events/BattleErrorEvent;)V"));
            return methods;
        }
        
        private static void onBattleStarted0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattleStartedEvent;)V
            // (Lrobocode/control/events/BattleStartedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattleStarted(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattleStartedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onBattleFinished1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattleFinishedEvent;)V
            // (Lrobocode/control/events/BattleFinishedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattleFinished(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattleFinishedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onBattleCompleted2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattleCompletedEvent;)V
            // (Lrobocode/control/events/BattleCompletedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattleCompleted(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattleCompletedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onBattlePaused3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattlePausedEvent;)V
            // (Lrobocode/control/events/BattlePausedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattlePaused(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattlePausedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onBattleResumed4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattleResumedEvent;)V
            // (Lrobocode/control/events/BattleResumedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattleResumed(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattleResumedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onRoundStarted5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/RoundStartedEvent;)V
            // (Lrobocode/control/events/RoundStartedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onRoundStarted(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.RoundStartedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onRoundEnded6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/RoundEndedEvent;)V
            // (Lrobocode/control/events/RoundEndedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onRoundEnded(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.RoundEndedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onTurnStarted7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/TurnStartedEvent;)V
            // (Lrobocode/control/events/TurnStartedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onTurnStarted(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.TurnStartedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onTurnEnded8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/TurnEndedEvent;)V
            // (Lrobocode/control/events/TurnEndedEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onTurnEnded(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.TurnEndedEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onBattleMessage9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattleMessageEvent;)V
            // (Lrobocode/control/events/BattleMessageEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattleMessage(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattleMessageEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void onBattleError10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lrobocode/control/events/BattleErrorEvent;)V
            // (Lrobocode/control/events/BattleErrorEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::robocode.control.events.IBattleListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.events.IBattleListener>(@__env, @__obj);
            @__real.onBattleError(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.events.BattleErrorEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.events.@__IBattleListener(@__env);
            }
        }
    }
    #endregion
}
