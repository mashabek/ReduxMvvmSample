# ReduxMvvmSample
Applying Redux architecture to a WPF app together with MVVM

This is a simple Customer CRUD application. The purpose is to show Redux.net together with MVVM in WPF application. 
The whole WPF/Xamarin development seems lacking tools for controlling state of an app, which causes a lot of pain as infrastructure grows up. 
Pure MVVM doesn't resolve this problem, as it only cares about separating View from Business Logic. 
In this context Redux will cut off modifying part of a ViewModel. Basically ViewModel will ask for mutation by dispatching an action to a store.
I don't use any MVVM framework, but it is possible to use one.
