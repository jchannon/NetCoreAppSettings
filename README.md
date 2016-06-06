# Question
The code in `app` folder is an application.

This has a dependency on `depa`.

`depa` library may want to use a strongly typed class for the app settings.

`depa` depends on `depb`

`depb` may also want to use the configuration class to retrieve a connection string for example

How?

# Answer

Using `Microsoft.Extensions.Configuration.ConfigurationBinder.Bind` you can bind a json file to a class.

That way you can bind `appsettings.json` to a class in `depa` and `depB`.

To get `depb` configuration passed to it, it has to be sent into a `depb` class constructor, the same applies to `depa`.  Using the binding and a container these configuration classes can be registered with a container and therefore automatically resolved.


