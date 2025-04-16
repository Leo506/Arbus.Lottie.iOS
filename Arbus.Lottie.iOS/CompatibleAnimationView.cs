namespace Airbnb.Lottie;

public partial class CompatibleAnimationView
{
    public static CompatibleAnimationView AnimationNamed(string name)
    {
        return new CompatibleAnimationView(CompatibleAnimation.Named((NSString)name));
    }
    
    public CompatibleAnimationView LoopAnimation()
    {
        this.LoopAnimationCount = -1;
        return this;
    }

    public CompatibleAnimationView PlayAnimation()
    {
        this.Play();
        return this;
    }
}