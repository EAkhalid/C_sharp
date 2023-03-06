# C# create controls from attribute class annotation 
The goals of this code is to create a form of a class using annotation and reflection, 
for each attribute of the class Person in Models project, we determined the control must be instanced.
# Project Models
This a class library, contains class Person  my model and class DictionnaryManagement.
## Class Person
The class Person is an example to show you how to create a form using the annotation View for each attribute in the class person and specify the type of control size, height, width and items.
## Class DictionnaryManagement
The DictionnaryManagement<T value> has an attribute type IDictionary<string, T>   generic collection which stores key-value pairs in whatever order.
The following example shows how to create a DictionnaryManagement and add an Object.
```
DictionnaryManagement<Person> personManagement=new DictionnaryManagement<Person>();
```
# Annotation Reflection
## Class View
Class View inherits the class Attribute, is annoted by AttributeUsage (AttributeTargets. Property) the annotation can be applied in the propriety of the class target.
# WindowsForm Project
Class MyPanel inherits FlowLayoutPanel control  arranges its contents in a horizontal or vertical flow direction. 
You can wrap the control's contents from one row to the next, or from one column to the next. Alternately, you can clip instead of wrap its contents.
## ChoicePanel
Class ChoicePanel inherits MyPanel, create a label and RadioButton Control.
## ComboxPanel
Class ComboxPanel inherits MyPanel, create a label and Combobox Control.
## LabledTextField
Class LabledTextField inherits MyPanel, create a label and TextBox Control.
## TextAerea
Class TextAerea inherits MyPanel, create a label and TextBox multiligne Control.
## Design Pattern Factory
We're going to create a formControlPanel abstract class and concrete classes implementing the formControlPanel interface. A factory class ControlFactory is defined as a next step.
#Presentation
##Myform
Presentation project contains a windows form with five panel :
```
 private Panel leftPanel;
 private Panel sideBarPanel;
 private Panel topPanel;
 protected Panel headerPanel;
```
MyForm contains also two FlowLayoutPanel, one to sidebar menu and another for the content.
MyForm is a temple you must be inherited for each new form in the project.




