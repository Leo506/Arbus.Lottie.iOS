using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Airbnb.Lottie
{
    [BaseType(typeof(NSObject), Name="_TtC6Lottie19CompatibleAnimation")]
    interface CompatibleAnimation
    {
        // + (CompatibleAnimation * _Nonnull)named:(NSString * _Nonnull)name
        [Static]
        [Export("named:")]
        CompatibleAnimation Named(NSString name);
    }
    
    [BaseType(typeof(UIView), Name="_TtC6Lottie23CompatibleAnimationView")]
    interface CompatibleAnimationView
    {
        // @property (nonatomic) CGFloat animationSpeed;
        [Export("animationSpeed")]
        nfloat AnimationSpeed { get; set; }
        
        // @property (nonatomic) CGFloat loopAnimationCount;
        [Export("loopAnimationCount")]
        nfloat LoopAnimationCount { get; set; }
        
        // - (nonnull instancetype)initWithCompatibleAnimation:(CompatibleAnimation * _Nonnull)compatibleAnimation;
        [Export("initWithCompatibleAnimation:")]
        NativeHandle Constructor(CompatibleAnimation compatibleAnimation);

        // - (void)play;
        [Export("play")]
        void Play();

        // - (void)stop;
        [Export("stop")]
        void Stop();

        // - (void)pause;
        [Export("pause")]
        void Pause();
    }
}