<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569619/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T376991)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MarsTemperature/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MarsTemperature/MainWindow.xaml))
<!-- default file list end -->
# How to customize chart annotations


<p>This example demonstrates how to modify an annotation layout and content.</p>


<h3>Description</h3>

<p>To customize the annotation layout,&nbsp;dock&nbsp;the annotation to the required element. Then, specify the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsFreePosition_VerticalAlignmenttopic">FreePosition.VerticalAlignment</a><strong>&nbsp;</strong>and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsFreePosition_HorizontalAlignmenttopic">FreePosition.HorizontalAlignment</a>&nbsp;properties.&nbsp;
  
<br>To anchor an annotation to the required pane, specify the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsPaneAnchorPoint_Panetopic">PaneAnchorPoint.Pane</a>&nbsp;property. Then, define the axes and their values to specify the anchor point using the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsPaneAnchorPoint_AxisXCoordinatetopic">PaneAnchorPoint.AxisXCoordinate</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsPaneAnchorPoint_AxisYCoordinatetopic">PaneAnchorPoint.AxisYCoordinate</a>&nbsp;properties.

If the [PaneAnchorPoint.Pane](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.PaneAnchorPoint.Pane) and [AxisCoordinate.Axis](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.AxisCoordinate.Axis) properties are unspecified, the default pane and primary axes are used to display the annotation. You can leave the **Pane** and **Axis** properties undefined if you plot the annotation on the default pane with primary axes.

<br>To use the data template for annotation&nbsp;content,&nbsp;create&nbsp;a&nbsp;DataTemplate object defining how to represent&nbsp;annotation&nbsp;content and assign this template to&nbsp;the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAnnotation_ContentTemplatetopic">Annotation.ContentTemplate</a>&nbsp;property.&nbsp;</p>

<br/>


