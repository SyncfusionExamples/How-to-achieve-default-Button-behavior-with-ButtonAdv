# How to achieve default Button behavior with ButtonAdv

This sample shows the demo on how to achieve the default button behavior with ButtonAdv.

# Assembly deployment
Refer ButtonAdv control dependencies section to get the list of assemblies or NuGet package needs to be added as reference to use the ButtonAdv control in any application.

# Creating simple application with Button
In this walk through, will create WPF application that contains Button control. By the following ways, one can add the controls:

1. Adding control via designer

2. Adding control manually in XAML

3. Adding control manually in C#

# Adding control via designer
WPF Button control can be added to the application by dragging ButtonAdv from toolbox and dropping it in designer view. After dropping the control in designer view, the assembly Syncfusion.Shared.WPF gets added into the project automatically. The following code snippets will also be added into the XAML

**[XAML]**
```
<syncfusion:ButtonAdv x:Name="buttonAdv" Label="ButtonAdv"/>
```
## Adding control manually in XAML
In order to add the control manually in XAML, follow the below steps.

1. Add the below required assembly reference to the project.
    *  Syncfusion.Shared.WPF

2. Import Syncfusion WPF schema http://schemas.syncfusion.com/wpf or the control namespace Syncfusion.Windows.Tools.Controls in XAML page.

3. Declare ButtonAdv control in XAML page.

**[XAML]**

```
    <Grid>
        <syncfusion:ButtonAdv Height="44"  VerticalAlignment="Center" HorizontalAlignment="Center" Width="162"/>
    </Grid>
```

## Adding control manually in C#
In order to the add control manually in C#, do the below steps.

1. Add the below required assembly reference to the project.

    *   Syncfusion.Shared.WPF
2. Import the Syncfusion.Windows.Tools.Controls namespace.

3. Create ButtonAdv control instance and add it to the window.

**[C#]**
```
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ButtonAdv button = new ButtonAdv();
        button.Height=44;
        button.Width=31;
        Root.Children.Add(button);
    }
}
```

# IsDefault mode
The IsDefault property indicates whether the ButtonAdv is a Default button and is used to activate the ButtonAdv by pressing using Enter key. When setting the IsDefault property to true, the user can invoke the button by pressing the Enter key.

**[XAML]**
```
<syncfusion:ButtonAdv x:Name="defaultButton" 
                      Label="Default" 
                      Grid.Column="1" Grid.Row="1" VerticalAlignment="Top" HorizontalAlignment="Center" Click="ButtonAdv_Click" IsDefault="True" />
```

## How to run this application?
To run this application, you need to first clone the How-to-achieve-default-Button-behavior-with-ButtonAdv and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
## License
Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.