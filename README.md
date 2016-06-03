# Question
The code in `app` folder is an application.

This has a dependency on `depa`.

`depa` library may want to use a strongly typed class for the app settings.

`depa` depends on `depb`

`depb` may also want to use the configuration class to retrieve a connection string for example

How?

# Answer

Using `Microsoft.Extensions.Configuration.ConfigurationBinder.Bind` you can bind a json file to a class.

That way yo can bind `appsettings.json` to a class in `depa`.

To get `depb` configuration passed to it, it has to be sent into a `depb` class constructor.  The `depa` configuration class has to contain a `DepBConfiguration` property on it so that when `app` binds `appsettings.json` it can use `DepBConfiguration` values to bind. See the `appsettings.json` file in the repo.

The downside to this is if you want to share values between libraries is that they have to be duplicated unless anyone knows a better way.