namespace MAUIControls;

public partial class PictureInPicture : ContentView
{
    public static readonly BindableProperty BigImageProperty =
        BindableProperty.Create(
            propertyName: "BigImage",
            returnType: typeof(string),
            typeof(PictureInPicture),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: BigImageSourceChanged);

    public static readonly BindableProperty SmallImageProperty =
        BindableProperty.Create(
            propertyName: "SmallImage",
            returnType: typeof(string),
            typeof(PictureInPicture),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: SmallImageSourceChanged);


    private static void BigImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (PictureInPicture)bindable;
        control.imgBig.Source = newValue.ToString();
    }

    private static void SmallImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (PictureInPicture)bindable;
        control.imgSmall.Source = newValue.ToString();
    }  

    public string BigImage
    {
        get
        {
            return base.GetValue(BigImageProperty).ToString();
        }
        set
        {
            base.SetValue(BigImageProperty, value);
        }
    }

    public string SmallImage
    {
        get
        {
            return base.GetValue(SmallImageProperty).ToString();
        }
        set
        {
            base.SetValue(SmallImageProperty, value);
        }
    }

    public PictureInPicture()
    {
        InitializeComponent();
    }
}