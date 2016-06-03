The code in `app` folder is an application.

This has a dependency on `depa`.

`depa` library may want to use a strongly typed class for the app settings.

`depa` depends on `depb`

`depb` may also want to use the configuration class to retrieve a connection string for example or even just a `ConfigurationManager.AppSettings["blah"]` alternative

How?
