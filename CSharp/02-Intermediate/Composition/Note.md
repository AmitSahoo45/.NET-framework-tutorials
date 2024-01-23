# Composition

- A kind of relationship between two classes that allows one to contain the other.
- Has-a relationship
- Eg. Car has an Engine.

### Benefits
- Code re-use
- Flexibilty
- A means to loose coupling

### Example
We are designing an application and as a part of that we need to have a class called *DB Migrator* that is responsible migrating our database.
Installer for installing our app in a DB environment.

Both requires logging.
For that we can develop a Logger class which will help us with the Logging.