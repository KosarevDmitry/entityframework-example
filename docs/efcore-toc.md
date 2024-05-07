source: [EntityFramework.Docs/entity-framework/core]
# Entity Framework Core
## Welcome!
  - Entity Framework Core
   - The model
   - Querying
   - Saving data
   - EF O/RM considerations
   - Next steps

## "What's new in EF Core 8.0"
  - What's New in EF Core 8
   - Value objects using Complex Types
    - Simple example
    - Configuration of complex types
    - Mutability
    - Reference types as complex types
     - Immutable class
     - Immutable record
    - Value types as complex types
     - Mutable struct
     - Immutable struct
     - Immutable struct record
    - Nested complex types
    - Queries
     - Projections
    - Use in predicates
    - Manipulation of complex type values
    - Current limitations
   - Primitive collections
    - Primitive collection properties
    - Queries with primitive collections
    - Primitive collections in JSON documents
    - Mapping primitive collections to a table
   - Enhancements to JSON column mapping
    - Translate element access into JSON arrays
    - Translate queries into embedded collections
    - JSON Columns for SQLite
     - Queries into JSON columns
     - Updating JSON columns
   - HierarchyId in .NET and EF Core
    - Support in .NET and EF Core
    - Modeling hierarchies
    - Querying hierarchies
    - Updating hierarchies
   - Raw SQL queries for unmapped types
   - Enhancements to lazy-loading
    - Lazy-loading for no-tracking queries
    - Explicit loading from untracked entities
    - Opt-out of lazy-loading for specific navigations
   - Access to tracked entities
    - Lookup tracked entities by primary, alternate, or foreign key
   - Model building
    - Discriminator columns have max length
    - DateOnly/TimeOnly supported on SQL Server
    - Reverse engineer Synapse and Dynamics 365 TDS
   - Enhancements to Math translations
   - Checking for pending model changes
   - Enhancements to SQLite scaffolding
   - Sentinel values and database defaults
    - Database defaults for booleans
    - Database defaults for enums
    - Using a nullable backing field
   - Better ExecuteUpdate and ExecuteDelete
   - Better use of `IN` queries
   - Numeric rowversions for SQL Azure/SQL Server
   - Parentheses elimination
   - Specific opt-out for RETURNING/OUTPUT clause
   - Other minor changes

## "Breaking changes in EF Core 8.0"
  - Breaking changes in EF Core 8 (EF8)
   - Target Framework
   - Summary
   - High-impact changes
    - `Contains` in LINQ queries may stop working on older SQL Server versions
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - Enums in JSON are stored as ints instead of strings by default
     - Old behavior
     - New behavior
     - Why
     - Mitigations
   - Medium-impact changes
    - SQL Server `date` and `time` now scaffold to .NET `DateOnly` and `TimeOnly`
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - Boolean columns with a database generated value are no longer scaffolded as nullable
     - Old behavior
     - New behavior
     - Why
     - Mitigations
   - Low-impact changes
    - SQLite `Math` methods now translate to SQL
     - Old Behavior
     - New behavior
     - Why
     - Mitigations
    - ITypeBase replaces IEntityType in some APIs
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - ValueConverter and ValueComparer expressions must use public APIs for the compiled model
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - ExcludeFromMigrations no longer excludes other tables in a TPC hierarchy
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - Non-shadow integer keys are persisted to Cosmos documents
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - Relational model is generated in the compiled model
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - Scaffolding may generate different navigation names
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - Discriminators now have a max length
     - Old behavior
     - New behavior
     - Why
     - Mitigations
    - SQL Server key values are compared case-insensitively
     - Old behavior
     - New behavior
     - Why
     - Mitigations

## "The plan for EF Core 9.0"
  - Plan for Entity Framework Core 9

## Getting started
### EF Core Overview
#### Install EF Core
  - Installing Entity Framework Core
   - Prerequisites
   - Get Entity Framework Core
    - .NET Core CLI
    - Visual Studio NuGet Package Manager Dialog
    - Visual Studio NuGet Package Manager Console
   - Get the Entity Framework Core tools
    - Get the .NET Core CLI tools
    - Get the Package Manager Console tools
   - Upgrading to the latest EF Core

#### Your first EF Core App
  - Getting Started with EF Core
   - Prerequisites
    - [.NET CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
   - Create a new project
    - [.NET CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
   - Install Entity Framework Core
    - [.NET Core CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
   - Create the model
    - [.NET CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
   - Create the database
    - [.NET CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
   - Create, read, update & delete
   - Run the app
    - [.NET CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
   - Next steps

#### NuGet packages
  - EF Core NuGet Packages
   - Package versions
   - Database providers
   - Tools
   - Extension packages
   - Other packages
   - Packages for database provider testing
   - Obsolete packages

### ASP.NET Core tutorial >>
        -  [https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro]
### Blazor Server with EF Core guidance >>
        -  [https://learn.microsoft.com/en-us/aspnet/core/blazor/blazor-server-ef-core]
### WPF .NET Core tutorial
  - Getting Started with WPF
   - Pre-Requisites
   - Create the Application
   - Install the Entity Framework NuGet packages
   - Define a Model
   - Lazy Loading
   - Bind Object to Controls
   - Adding a Details Grid
   - Add Code that Handles Data Interaction
   - Test the WPF Application
   - Property Change Notification
   - Next Steps

### Windows Forms tutorial
  - Getting Started with Windows Forms
   - Prerequisites
   - Create the Application
   - Install the EF Core NuGet packages
   - Define a Model
   - Define the DbContext
   - Adding controls to the form
   - Data binding
   - Configuring what is displayed
   - Connecting to EF Core
   - Populating the Products view
   - Saving changes
   - The final application
   - Learn more

### Xamarin tutorial
  - Getting Started with EF Core and Xamarin
   - Prerequisites
   - Download and run the sample project
   - Explore the code
   - Entity Framework Core NuGet packages
   - Model classes
   - Data context
   - Create, read, update & delete
    - Read
    - Create
    - Update
    - Delete
   - Next steps

## "Releases and planning (roadmap)"
### Current and planned releases
  - EF Core releases and planning
   - Stable releases
   - Guidance on updating to new releases
   - Release planning and schedules
   - EF Core 9.0

### Release planning process
  - Release planning process
   - Different kinds of releases
    - Patch releases
    - Major releases
   - Planning for major/minor releases
    - GitHub issue tracking
    - The planning process

### EF Core 9.0

## DbContext configuration and initialization
### Overview
  - DbContext Lifetime, Configuration, and Initialization
   - The DbContext lifetime
   - DbContext in dependency injection for ASP.NET Core
   - Simple DbContext initialization with 'new'
   - Using a DbContext factory (e.g. for Blazor)
   - DbContextOptions
    - Configuring the database provider
    - Other DbContext configuration
    - `DbContextOptions` versus `DbContextOptions<TContext>`
   - Design-time DbContext configuration
   - Avoiding DbContext threading issues
    - Asynchronous operation pitfalls
    - Implicitly sharing DbContext instances via dependency injection
   - More reading

### Context pooling
        -  [https://learn.microsoft.com/en-uscore/performance/advanced-performance-topics.md#dbcontext-pooling]
## Create a model
### Overview
  - Creating and Configuring a Model
   - Use fluent API to configure a model
    - Grouping configuration
     - Applying all configurations in an assembly
     - Using `EntityTypeConfigurationAttribute` on entity types
   - Use data annotations to configure a model
   - Built-in conventions
    - Removing an existing convention
     - Example: Don't create indexes for foreign key columns
   - Debug view

### Entity types
  - Entity Types
   - Including types in the model
   - Excluding types from the model
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
    - Excluding from migrations
   - Table name
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Table schema
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - View mapping
   - Table-valued function mapping
   - Table comments
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Shared-type entity types

### Entity properties
  - Entity Properties
   - Included and excluded properties
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Column names
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Column data types
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
    - Maximum length
     - [Data Annotations](#tab/data-annotations)
     - [Fluent API](#tab/fluent-api)
    - Precision and Scale
     - [Data Annotations](#tab/data-annotations)
     - [Fluent API](#tab/fluent-api)
    - Unicode
     - [Data Annotations](#tab/data-annotations)
     - [Fluent API](#tab/fluent-api)
   - Required and optional properties
    - Conventions
     - [Without NRT (default)](#tab/without-nrt)
     - [With NRT](#tab/with-nrt)
    - Explicit configuration
     - [Data Annotations](#tab/data-annotations)
     - [Fluent API](#tab/fluent-api)
   - Column collations
   - Column comments
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Column order
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)

### Keys
  - Keys
   - Configuring a primary key
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Value generation
   - Primary key name
   - Key types and values
   - Alternate Keys

### Generated values
  - Generated Values
   - Default values
   - Computed columns
   - Primary keys
   - Explicitly configuring value generation
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Date/time value generation
    - Creation timestamp
    - Update timestamp
   - Overriding value generation
   - No value generation
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)

### Shadow and indexer properties
  - Shadow and Indexer Properties
   - Foreign key shadow properties
   - Configuring shadow properties
   - Accessing shadow properties
   - Configuring indexer properties
   - Property bag entity types

### Relationships
#### Overview
  - Introduction to relationships
   - Relationships in object models
   - Relationships in relational databases
   - Mapping relationships in EF Core 👍
   - Find out more
   - Using relationships

#### One-to-many
  - One-to-many relationships
   - Required one-to-many
   - Optional one-to-many
   - Required one-to-many with shadow foreign key
   - Optional one-to-many with shadow foreign key
   - One-to-many without navigation to principal
   - One-to-many without navigation to principal and with shadow foreign key
   - One-to-many without navigation to dependents
   - One-to-many with no navigations
   - One-to-many with alternate key
   - One-to-many with composite foreign key
   - Required one-to-many without cascade delete
   - Self-referencing one-to-many

#### One-to-one
  - One-to-one relationships
   - Required one-to-one
   - Optional one-to-one
   - Required one-to-one with primary key to primary key relationship
   - Required one-to-one with shadow foreign key
   - Optional one-to-one with shadow foreign key
   - One-to-one without navigation to principal
   - One-to-one without navigation to principal and with shadow foreign key
   - One-to-one without navigation to dependent
   - One-to-one with no navigations
   - One-to-one with alternate key
   - One-to-one with composite foreign key
   - Required one-to-one without cascade delete
   - Self-referencing one-to-one

#### Many-to-many
  - Many-to-many relationships
   - Understanding many-to-many relationships
   - Examples
   - Basic many-to-many
   - Many-to-many with named join table
   - Many-to-many with join table foreign key names
   - Many-to-many with class for join entity
   - Many-to-many with navigations to join entity
   - Many-to-many with navigations to and from join entity
   - Many-to-many with navigations and changed foreign keys
   - Unidirectional many-to-many
   - Many-to-many and join table with payload
   - Custom shared-type entity type as a join entity
   - Many-to-many with alternate keys
   - Many-to-many and join table with separate primary key
   - Many-to-many without cascading delete
   - Self-referencing many-to-many
   - Symmetrical self-referencing many-to-many
   - Direct use of join table
   - Additional resources

#### Foreign and principal keys
  - Foreign and principal keys in relationships
   - Foreign keys
    - Non-nullable foreign key columns
    - Shadow foreign keys
    - Foreign key constraint names
    - Indexes for foreign keys
   - Principal keys
   - Relationships to keyless entities
   - Foreign keys in many-to-many relationships

#### Navigations
  - Relationship navigations
   - Reference navigations
   - Collection navigations
    - Collection types
    - Initialization of collection navigations
   - Configuring navigations
    - Required navigations

#### Conventions
  - Conventions for relationship discovery
   - Discovering navigations
    - Reference navigations
    - Collection navigations
    - Pairing navigations
   - Discovering foreign key properties
   - Determining cardinality
   - Shadow foreign key properties
   - Cascade delete
   - Many-to-many
   - Indexes
    - How to stop EF creating indexes for foreign keys
   - Foreign key constraint names
   - Additional resources

#### Mapping attributes
  - Mapping attributes (aka data annotations) for relationships
   - Where to get mapping attributes
   - RequiredAttribute
   - ForeignKeyAttribute
   - InversePropertyAttribute
   - DeleteBehaviorAttribute

#### Glossary
  - Glossary of relationship terms

### Indexes and constraints
  - Indexes
   - [Data Annotations](#tab/data-annotations)
   - [Fluent API](#tab/fluent-api)
   - Composite index
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Index uniqueness
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Index sort order
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Index naming and multiple indexes
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Index filter
   - Included columns
   - Check constraints

### Inheritance
  - Inheritance
   - Entity type hierarchy mapping
   - Table-per-hierarchy and discriminator configuration
    - Shared columns
   - Table-per-type configuration
   - Table-per-concrete-type configuration
    - TPC database schema
    - Key generation
    - Foreign key constraints
   - Summary and guidance

### Sequences
  - Sequences
   - Basic usage
   - Configuring sequence settings

### Backing fields
  - Backing Fields
   - Basic configuration
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Field and property access
   - Field-only properties

### Value conversions
  - Value Conversions
   - Overview
   - Configuring a value converter
    - Bulk-configuring a value converter
   - Pre-defined conversions
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - The ValueConverter class
   - Built-in converters
   - Column facets and mapping hints
   - Examples
    - Simple value objects
    - Composite value objects
    - Collections of primitives
    - Collections of value objects
    - Value objects as keys
    - Use ulong for timestamp/rowversion
    - Specify the DateTime.Kind when reading dates
    - Use case-insensitive string keys
    - Handle fixed-length database strings
    - Encrypt property values
   - Limitations

### Value comparers
  - Value Comparers
   - Background
   - Shallow vs. deep comparison
   - Simple immutable classes
   - Simple immutable structs
   - Mutable classes
    - [EF Core 5.0](#tab/ef5)
    - [Older versions](#tab/older-versions)
   - Key comparers
   - Overriding the default comparer

### Data seeding
  - Data Seeding
   - Model seed data
    - Limitations of model seed data
   - Manual migration customization
   - Custom initialization logic

### Entity type constructors
  - Entity types with constructors
   - Binding to mapped properties
    - Read-only properties
   - Injecting services

### Advanced table mapping
  - Advanced table mapping
   - Table splitting
    - Configuration
    - Usage
    - Optional dependent entity
    - Concurrency tokens
    - Inheritance
   - Entity splitting
    - Configuration
    - Configuring the linking foreign key
    - Limitations
   - Table-specific facet configuration

### Owned entity types
  - Owned Entity Types
   - Configuring types as owned
   - Implicit keys
   - Collections of owned types
   - Mapping owned types with table splitting
   - Sharing the same .NET type among multiple owned types
   - Nested owned types
   - Configuring owned types
   - Storing owned types in separate tables
   - Querying owned types
   - Limitations
    - By-design restrictions
    - Current shortcomings
    - Shortcomings in previous versions

### Keyless entity types
  - Keyless Entity Types
   - Defining Keyless entity types
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Keyless entity types characteristics
   - Usage scenarios
   - Mapping to database objects
   - Example

### Spatial data
  - Spatial Data
   - Installing
   - NetTopologySuite
   - Longitude and Latitude
   - Querying Data
   - Reverse engineering
   - SRID Ignored during client operations
   - Additional resources
    - Database-specific information
    - Other resources

### Bulk configuration
  - Model bulk configuration
   - Bulk configuration in OnModelCreating
    - Drawbacks of the Metadata API
   - Pre-convention configuration
    - Ignoring types
    - Default type mapping
    - Limitations of pre-convention configuration
   - Conventions
    - Adding a new convention
     - Example: Constrain length of discriminator properties
     - Example: Default length for all string properties
    - Replacing an existing convention
     - Example: Opt-in property mapping
    - Conventions implementation considerations
    - IConventionContext
     - Example: NotMappedAttribute convention
    - IConventionModel
   - When to use each approach for bulk configuration

### Alternating models with same DbContext
  - Alternating between multiple models with the same DbContext type
   - IModelCacheKeyFactory

## Manage database schemas
### Overview
  - Managing Database Schemas

### Migrations
#### Overview
  - Migrations Overview
   - Getting started
    - Install the tools
    - Create your first migration
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio](#tab/vs)
    - Create your database and schema
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio](#tab/vs)
    - Evolving your model
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio](#tab/vs)
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio](#tab/vs)
    - Excluding parts of your model
    - Next steps
   - Additional resources

#### Managing migrations
  - Managing Migrations
   - Add a migration
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
    - Namespaces
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio](#tab/vs)
   - Customize migration code
    - Column renames
    - Adding raw SQL
    - Arbitrary changes via raw SQL
   - Remove a migration
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Listing migrations
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Checking for pending model changes
   - Resetting all migrations
   - Additional resources

#### Applying migrations
  - Applying Migrations
   - SQL scripts
    - [.NET Core CLI](#tab/dotnet-core-cli)
     - Basic Usage
     - With From (to implied)
     - With From and To
    - [Visual Studio](#tab/vs)
     - Basic Usage
     - With From (to implied)
     - With From and To
   - Idempotent SQL scripts
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Command-line tools
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Bundles
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
    - `efbundle`
    - Migration bundle example
   - Apply migrations at runtime

#### Team environments
  - Migrations in Team Environments
   - Merging
   - Resolving conflicts

#### Custom operations
  - Custom Migrations Operations
   - Using MigrationBuilder.Sql()
   - Using a MigrationOperation

#### Use a separate project
  - Using a Separate Migrations Project
   - Steps
   - [.NET Core CLI](#tab/dotnet-core-cli)
   - [Visual Studio](#tab/vs)

#### Multiple providers
  - Migrations with Multiple Providers
   - Using multiple context types
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Using one context type
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)

#### Custom history table
  - Custom Migrations History Table
   - Schema and table name
   - Other changes

### Create and drop APIs
  - Create and Drop APIs
   - EnsureDeleted
   - EnsureCreated
   - SQL Script
   - Multiple DbContext classes

### Reverse engineering (scaffolding)
#### Overview
  - Scaffolding (Reverse Engineering)
   - Prerequisites
   - Required arguments
    - Connection string
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
     - User secrets for connection strings
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
     - [.NET Core CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
     - Connection strings in the scaffolded code
    - Provider name
   - Command line options
    - Specifying tables and views
     - [.NET CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
     - [.NET CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
     - [.NET CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
    - Preserving database names
    - Use mapping attributes (aka Data Annotations)
    - DbContext name
    - Target directories and namespaces
     - [.NET CLI](#tab/dotnet-core-cli)
     - [Visual Studio PMC](#tab/vs)
   - The scaffolded code
    - C# Nullable reference types
    - Many-to-many relationships
    - Other programming languages
    - Customizing the code
     - Scaffold once only
     - Repeated scaffolding
   - How it works
   - Limitations

#### Custom templates
  - Custom Reverse Engineering Templates
   - Prerequisites
   - Adding the default templates
   - Introduction to T4
   - Customize the entity types
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Updating templates
   - Advanced usage
    - Ignoring the input model
    - Entity configuration classes
    - Scaffolding other types of files
  - <#= Options.ContextName #>

## Query data
### Overview
  - Querying Data
   - Loading all data
   - Loading a single entity
   - Filtering
   - Further readings

### Client vs. server evaluation
  - Client vs. Server Evaluation
   - Client evaluation in the top-level projection
   - Unsupported client evaluation
   - Explicit client evaluation
   - Potential memory leak in client evaluation
   - Previous versions

### Tracking vs. no-tracking
  - Tracking vs. No-Tracking Queries
   - Tracking queries
   - No-tracking queries
   - Identity resolution
   - Configuring the default tracking behavior
   - Tracking and custom projections
   - Previous versions

### Load related data
##### Overview
  - Loading Related Data

##### Eager loading
  - Eager Loading of Related Data
   - Eager loading
   - Including multiple levels
   - Filtered include
   - Include on derived types
   - Model configuration for auto-including navigations

##### Explicit loading
  - Explicit Loading of Related Data
   - Explicit loading
   - Querying related entities

##### Lazy loading
  - Lazy Loading of Related Data
   - Lazy loading with proxies
   - Lazy loading without proxies

##### Related data and serialization
  - Related data and serialization

### Split queries
  - Single vs. Split Queries
   - Performance issues with single queries
    - Cartesian explosion
    - Data duplication
   - Split queries
   - Enabling split queries globally
   - Characteristics of split queries

### Complex query operators
  - Complex Query Operators
   - Join
   - GroupJoin
   - SelectMany
    - Collection selector doesn't reference outer
    - Collection selector references outer in a where clause
    - Collection selector references outer in a non-where case
   - GroupBy
   - Left Join

### Pagination
  - Pagination
   - Offset pagination
   - Keyset pagination
    - Multiple pagination keys
   - Indexes
   - Additional resources

### SQL queries
  - SQL Queries
   - Basic SQL queries
   - Passing parameters
    - Dynamic SQL and parameters
   - Composing with LINQ
    - Including related data
   - Change Tracking
   - Querying scalar (non-entity) types
   - Executing non-querying SQL  :+1:
   - Limitations

### Database functions
  - Database Functions
   - Types of database functions
    - Built-in vs user-defined functions
    - Aggregate vs scalar vs table-valued functions
    - Niladic functions
   - Database function mappings in EF Core
    - Built-in function mapping
    - EF.Functions mapping
    - User-defined function mapping
   - See also

### User-defined function mapping
  - User-defined function mapping
   - Mapping a method to a SQL function
   - Mapping a method to a custom SQL
   - Configuring nullability of user-defined function based on its arguments
   - Mapping a queryable function to a table-valued function

### Global query filters
  - Global Query Filters
   - Example
   - Use of navigations
   - Accessing entity with query filter using required navigation
   - Disabling Filters
   - Limitations

### Query tags
  - Query tags
   - Known limitations

### Comparisons with null values in queries
  - Query null semantics
   - Introduction
   - Treatment of nullable values in functions
   - Writing performant queries
   - Using relational null semantics

### How queries work
  - How Queries Work
   - The life of a query
   - When queries are executed

## Save data
### Overview
  - Saving Data
   - Approach 1: change tracking and SaveChanges
   - Approach 2: ExecuteUpdate and ExecuteDelete ("bulk update")
   - Summary

### Basic save
  - Basic SaveChanges
   - Adding Data
   - Updating Data
   - Deleting Data
   - Multiple Operations in a single SaveChanges

### Related data
  - Saving Related Data
   - Adding a graph of new entities
   - Adding a related entity
   - Changing relationships
   - Removing relationships

### Cascade delete
  - Cascade Delete
   - When cascading behaviors happen
    - Deleting a principal/parent
    - Severing a relationship
   - Where cascading behaviors happen
    - Cascade delete of tracked entities
    - Cascade delete in the database
    - Database cascade limitations
   - Cascading nulls
   - Configuring cascading behaviors
    - Impact on database schema
    - Impact on SaveChanges behavior
     - Required relationship with dependents/children loaded
     - Required relationship with dependents/children not loaded
     - Optional relationship with dependents/children loaded
     - Optional relationship with dependents/children not loaded

### Concurrency conflicts
  - Handling Concurrency Conflicts
   - Optimistic concurrency
   - Native database-generated concurrency tokens
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Application-managed concurrency tokens
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)
   - Resolving concurrency conflicts
   - **Using isolation levels for concurrency control** [^1]
   - Additional resources

### ExecuteUpdate and ExecuteDelete
  - ExecuteUpdate and ExecuteDelete
   - ExecuteDelete
   - ExecuteUpdate
    - Updating multiple properties
    - Referencing the existing property value
    - Navigations and related entities
   - Change tracking
   - Transactions
   - Concurrency control and rows affected
   - Limitations
   - Additional resources

### Transactions [^2]
  - Using Transactions
   - Default transaction behavior
   - Controlling transactions
   - Savepoints
   - Cross-context transaction
    - Allow connection to be externally provided
    - Share connection and transaction
   - Using external DbTransactions (relational databases only)
   - Using System.Transactions
    - **Limitations of System.Transactions** 

### Disconnected entities
  - Disconnected entities
   - Identifying new entities
    - Client identifies new entities
    - With auto-generated keys
    - With other keys
   - Saving single entities
   - Working with graphs
    - Identity resolution
    - All new/all existing entities
    - Mix of new and existing entities
   - Handling deletes
   - TrackGraph

## Change tracking
### Overview
  - Change Tracking in EF Core
   - How to track entities
   - Entity states
   - Tracking from queries
   - Simple query and update
   - Query then insert, update, and delete

### Explicitly tracking entities
  - Explicitly Tracking Entities
   - Introduction
    - Generated versus explicit key values
   - Inserting new entities
    - Explicit key values
    - Generated key values
   - Attaching existing entities
    - Explicit key values
    - Generated key values
   - Updating existing entities
    - Explicit key values
    - Generated key values
   - Deleting existing entities
   - Deleting dependent/child entities
   - Deleting principal/parent entities
    - Optional relationships
    - Required relationships
   - Custom tracking with TrackGraph

### Accessing tracked entities
  - Accessing Tracked Entities
   - Using DbContext.Entry and EntityEntry instances
    - Working with the entity
    - Working with a single property
    - Working with a single navigation
    - Working with all properties of an entity
     - Setting current or original values from an entity or DTO
     - Setting current or original values from a dictionary
     - Setting current or original values from the database
     - Creating a cloned object containing current, original, or database values
    - Working with all navigations of an entity
    - Working with all members of an entity
   - Find and FindAsync
    - Composite keys
   - Using ChangeTracker.Entries to access all tracked entities
   - Using DbSet.Local to query tracked entities
    - The local view
    - Using Local to add and remove entities
    - Using the local view for Windows Forms or WPF data binding

### Changing foreign keys and navigations
  - Changing Foreign Keys and Navigations
   - Overview of foreign keys and navigations
    - Example model
   - Relationship fixup
    - Fixup by query
    - Fixup to locally tracked entities
   - Changing relationships using navigations
    - Adding or removing from collection navigations
    - Changing reference navigations
   - Changing relationships using foreign key values
   - Fixup for added or deleted entities
    - Adding to a collection navigation
    - Removing from a collection navigation
     - Optional relationships
     - Required relationships
     - Delete orphans timing and re-parenting
    - Changing a reference navigation
     - Optional one-to-one relationships
     - Required one-to-one relationships
    - Deleting an entity
     - Optional relationships
     - Required relationships
     - Cascade delete timing and re-parenting
   - Many-to-many relationships
    - How many-to-many relationships work
    - Skip navigations
    - Skip navigations only
    - Join entities with payloads
     - Payloads with generated values
     - Explicitly setting payload values

### Change detection and notifications
  - Change Detection and Notifications
   - Snapshot change tracking
    - When change detection is needed
    - Methods that automatically detect changes
    - Disabling automatic change detection
    - Detecting changes and value conversions
   - Notification entities
    - Implementing notification entities
    - Configuring notification entities
    - Using notification entities
   - Change-tracking proxies
   - Change tracking events

### Identity resolution
  - Identity Resolution in EF Core
   - Introduction
   - Updating an entity
    - Call Update
    - Query then apply changes
    - Use original values
   - Attaching a serialized graph
    - Graphs with no duplicates
    - Handling duplicates
     - Preserve references
     - Resolve duplicates
   - Failing to set key values
   - Overusing a single DbContext instance
   - Identity resolution and queries
   - Overriding object equality
    - Comparing key properties

### Additional change tracking features
  - Additional Change Tracking Features
   - `Add` versus `AddAsync`
   - `AddRange`, `UpdateRange`, `AttachRange`, and `RemoveRange`
   - DbContext versus DbSet methods
   - Property versus field access
   - Temporary values
    - Accessing temporary values
    - Manipulating temporary values
   - Working with default values
    - Using nullable properties
    - Using nullable backing fields
     - Nullable backing fields for bool properties
    - Schema defaults only

### Change tracker debugging
  - Change Tracker Debugging
   - Change tracker debug view
    - The short view
    - The long view
     - Property values
     - Navigation values
   - Change tracker logging
   - The model

## Logging, events, and diagnostics
### Overview
  - Overview of Logging and Interception
   - Quick reference
   - Simple logging
   - Microsoft.Extensions.Logging
   - Events
   - Interception
   - Diagnostic listeners

### Simple logging
  - Simple Logging
   - Configuration
   - Directing the logs
    - Logging to the console
    - Logging to the debug window
    - Logging to a file
   - Getting detailed messages
    - Sensitive data
    - Detailed query exceptions
   - Filtering
    - Log levels
    - Specific messages
    - Message categories
    - Custom filters
   - Configuration for specific messages
    - Changing the log level for an event
    - Suppress logging an event
    - Throw for an event
   - Message contents and formatting
    - Using UTC time
    - Single line logging
    - Other content options
   - Moving from EF6

### Microsoft.Extensions.Logging
  - Using Microsoft.Extensions.Logging in EF Core
   - ASP.NET Core applications
   - Other application types
    - [EF Core 3.0 and above](#tab/v3)
    - [EF Core 2.1](#tab/v2)
   - Getting detailed messages
    - Sensitive data
    - Detailed query exceptions
   - Configuration for specific messages
    - Changing the log level for an event
    - Suppress logging an event
    - Throw for an event
   - Filtering and other configuration

### Events
  - .NET Events in EF Core
   - Events raised by EF Core
    - Example: Timestamp state changes

### Interceptors
  - Interceptors
   - Registering interceptors
   - Database interception
    - Example: Command interception to add query hints
    - Example: Connection interception for SQL Azure authentication using AAD
    - Example: Advanced command interception for caching
     - Interceptor state
     - Before execution
     - After execution
     - Demonstration
   - SaveChanges interception
    - Example: SaveChanges interception for auditing
     - The application context
     - The audit context
     - The interceptor
     - The audit message
     - Detecting success
     - Detecting failure
     - Demonstration

### Diagnostic listeners
  - Using Diagnostic Listeners in EF Core
   - Example: Observing diagnostic events

### Event counters
  - Event Counters
   - Attach to a process using dotnet-counters
    - [Windows](#tab/windows)
    - [Linux or macOS](#tab/fluent-api)
   - Counters and their meaning
   - Additional resources

## Testing
### Introduction to testing
  - Testing EF Core Applications
   - Involving the database (or not)
   - Further reading

### Choosing a testing strategy
  - Choosing a testing strategy
   - Testing against the database may be easier than it seems
   - Different types of test doubles
    - SQLite as a database fake
    - In-memory as a database fake
    - Mocking or stubbing DbContext and DbSet
    - Repository pattern
   - Overall comparison
   - Summary

### Testing against your production database system
  - Testing against your production database system
   - Setting up your database system
   - Creating, seeding and managing a test database
   - Tests which modify data
   - Tests which explicitly manage transactions
   - Efficient database creation
   - Efficient database cleanup
   - Summary

### Testing without your production database system
  - Testing without your production database system
   - Repository pattern
   - SQLite in-memory
   - In-memory provider
    - In-memory database naming
    - Transactions
    - Views

## Performance
### Introduction
  - Introduction to Performance
   - Identify bottlenecks and measure, measure, measure
   - Aspects of data access performance
   - Know what's happening under the hood
   - Cache outside the database

### Performance diagnosis
  - Performance Diagnosis
   - Identifying slow database commands via logging
    - [Simple logging](#tab/simple-logging)
    - [Microsoft.Extensions.Logging](#tab/microsoft-extensions-logging)
   - Correlating database commands to LINQ queries
   - Other interfaces for capturing performance data
   - Inspecting query execution plans
   - Event counters
   - Benchmarking with EF Core
    - [Load entities](#tab/load-entities)
    - [Load entities, no tracking](#tab/load-entities-no-tracking)
    - [Project only ranking](#tab/project-only-ranking)
    - [Calculate in database](#tab/calculate-in-database)

### Efficient querying
  - Efficient Querying
   - Use indexes properly
   - Project only properties you need
   - Limit the resultset size
   - Efficient pagination
   - Avoid cartesian explosion when loading related entities
   - Load related entities eagerly when possible
    - Beware of lazy loading
   - Buffering and streaming
    - Internal buffering by EF
   - Tracking, no-tracking and identity resolution
   - Using SQL queries
   - Asynchronous programming
   - Additional resources

### Efficient updating
  - Efficient Updating
   - Batching
   - Use ExecuteUpdate and ExecuteDelete when relevant
    - [EF Core 7.0](#tab/ef7)
    - [Older Versions](#tab/older-versions)

### Modeling for performance
  - Modeling for Performance
   - Denormalization and caching
    - Stored computed columns
    - Update cache columns when inputs change
    - Materialized/indexed views
   - Inheritance mapping

### Advanced performance topics
  - Advanced Performance Topics
   - DbContext pooling 👍
    - [With dependency injection](#tab/with-di)
    - [Without dependency injection](#tab/without-di)
    - Benchmarks
    - Managing state in pooled contexts
   - Compiled queries  
    - Limitations
   - Query caching and parameterization
   - Dynamically-constructed queries
    - [Expression API with constant](#tab/expression-api-with-constant)
    - [Expression API with parameter](#tab/expression-api-with-parameter)
    - [Simple with parameter](#tab/simple-with-parameter)  👍
   - Compiled models
    - Compiled model bootstrapping
    - Limitations
   - Reducing runtime overhead
     
## Miscellaneous
### Supported .NET implementations
  - .NET implementations supported by EF Core
   - .NET
   - .NET Core
   - .NET Standard
   - .NET Framework
   - Xamarin
   - Universal Windows Platform
   - Unity
   - Tizen

### Asynchronous programming
  - Asynchronous Programming
   - Async LINQ operators
   - Client-side async LINQ operators

### Nullable reference types
  - Working with Nullable Reference Types
   - Required and optional properties
   - Non-nullable properties and initialization
    - Required navigation properties
   - DbContext and DbSet
   - Navigating and including nullable relationships
   - Limitations in older versions

### Collations and case sensitivity
  - Collations and Case Sensitivity
   - Introduction to collations
   - Database collation
   - Column collation
   - Explicit collation in a query
    - Explicit collations and indexes
   - Translation of built-in .NET string operations
   - Additional resources
    - Database-specific information
    - Other resources

### Connection resiliency
  - Connection Resiliency
   - Custom execution strategy
   - Execution strategies and transactions
   - Transaction commit failure and the idempotency issue
    - Option 1 - Do (almost) nothing
    - Option 2 - Rebuild application state
    - Option 3 - Add state verification
    - Option 4 - Manually track the transaction
   - Additional resources

### Connection strings
  - Connection Strings
   - ASP.NET Core
   - WinForms & WPF Applications
   - Universal Windows Platform (UWP)

### Context pooling
        -  D:\src\EntityFramework.Docs\entity-framework\core\miscellaneous\context-pooling.md
### Support multi-tenant databases
  - Multi-tenancy
   - Supporting multi-tenancy
    - Blazor Server apps and the life of the factory
   - An example solution (single database)
   - Multiple schemas
   - Multiple databases and connection strings
    - Switching tenants
   - Performance notes
   - Conclusion

### Plug-in APIs
  - Plug-in APIs
   - List of services
   - Examples

### EF Core Architecture
#### Overview
  - EF Core Architecture
   - Articles
   - Community Standup
   - See also

#### Design-time tools
  - Design-time Tools Architecture
   - dotnet-ef
   - PMC Tools
   - ef.exe
   - EFCore.Design.dll
    - Creating a DbContext
    - Finding application services
    - Design-time services
    - Logging and exceptions

## Database providers
### Overview
  - Database Providers
   - Current providers
   - Adding a database provider to your application
   - [.NET Core CLI](#tab/dotnet-core-cli)
   - [Visual Studio](#tab/vs)

### Microsoft SQL Server and Azure SQL
#### Overview
  - Microsoft SQL Server EF Core Database Provider
   - Install
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Supported Database Engines

#### Temporal tables
  - SQL Server/Azure SQL temporal tables
   - Configuring a temporal table
   - Using temporal tables
   - Querying historical data
   - Restoring historical data

#### Value generation
  - SQL Server Value Generation
   - IDENTITY columns
    - Seed and increment
    - Inserting explicit values into IDENTITY columns
   - Sequences
   - GUIDs
   - Rowversions
    - [Data Annotations](#tab/data-annotations)
    - [Fluent API](#tab/fluent-api)

#### Function mappings
  - Function Mappings of the Microsoft SQL Server Provider
   - Aggregate functions
   - Binary functions
   - Conversion functions
   - Date and time functions
   - Numeric functions
   - String functions
   - Miscellaneous functions
   - See also

#### Columns
  - Column features specific to the Entity Framework Core SQL Server provider
   - Unicode and UTF-8
    - [EF Core 7.0](#tab/ef-core-7)
     - [Older versions](#tab/older-versions)
   - Sparse columns

#### Indexes
  - Index features specific to the Entity Framework Core SQL Server provider
   - Clustering
   - Fill factor
   - Online creation

#### Memory-optimized tables
  - Memory-Optimized Tables support in SQL Server EF Core Database Provider
   - Configuring a memory-optimized table

#### Hierarchical data
  - Hierarchical Data in the SQL Server EF Core Provider
   - Using HierarchyId in .NET and EF Core
    - [.NET Core CLI](#tab/netcore-cli)
    - [Visual Studio](#tab/visual-studio)
     - Modeling hierarchies
     - Querying hierarchies
     - Updating hierarchies
   - Function mappings
   - Additional resources

#### Spatial data
  - Spatial Data in the SQL Server EF Core Provider
   - Geography or geometry
   - Geography polygon rings
   - FullGlobe
   - Curves
   - Spatial function mappings
    - Aggregate functions
   - Additional resources

#### Specify Azure SQL Database options
  - Specifying Azure SQL Database Options

#### Miscellaneous
  - Miscellaneous notes for SQL Server
   - SaveChanges, database triggers and unsupported computed columns

### SQLite
#### Overview
  - SQLite EF Core Database Provider
   - Install
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Supported Database Engines
   - Limitations

#### SQLite limitations
  - SQLite EF Core Database Provider Limitations
   - Modeling limitations
   - Query limitations
   - Migrations limitations
    - Migrations limitations workaround
    - Idempotent script limitations
   - See also

#### Function mappings
  - Function Mappings of the SQLite EF Core Provider
   - Aggregate functions
   - Binary functions
   - Conversion functions
   - Date and time functions
   - Numeric functions
   - String functions
   - Miscellaneous functions
   - See also

#### Spatial data
  - Spatial Data in the SQLite EF Core Provider
   - Installing SpatiaLite
  - Debian/Ubuntu
  - macOS
   - Configuring SRID
   - Dimension
   - Spatial function mappings
    - Aggregate functions
   - Additional resources

#### Microsoft.Data.Sqlite >>
          -  [https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/]
### Azure Cosmos DB
#### Overview
  - EF Core Azure Cosmos DB Provider
   - Install
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Get started
   - Connecting and authenticating
   - Queries
    - LINQ queries
    - SQL queries
   - Azure Cosmos DB options
   - Cosmos-specific model customization
    - Partition keys
    - Provisioned throughput
    - Time-to-live
   - Embedded entities
    - Collections of primitive types
   - Working with disconnected entities
   - Optimistic concurrency with eTags

#### Work with unstructured data
  - Working with Unstructured Data in EF Core Azure Cosmos DB Provider
   - Accessing the raw JSON
   - Using CosmosClient
   - Missing property values

#### Azure Cosmos DB limitations
  - EF Core Azure Cosmos DB Provider Limitations

#### Function mappings
  - Function Mappings of the Azure Cosmos DB EF Core Provider
   - Date and time functions
   - Numeric functions
   - String functions
   - Miscellaneous functions

#### End-to-end sample
  - The Planetary Docs Sample
   - Get started
    - Clone this repo
    - Create an Azure Cosmos DB instance
    - Initialize the database
    - Configure and run the Blazor app
   - Project Details
   - Introducing Planetary Docs
    - Azure Cosmos DB setup
    - Entity Framework Core
    - The Data Service
     - Load a document
     - Query documents
    - Create a document
     - Update a document
     - Delete a document
     - Search metadata (tags or authors)
    - Deal with document audits
   - Conclusion

### In-memory (not recommended)
  - EF Core In-Memory Database Provider
   - Install
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)
   - Get Started
   - Supported Database Engines

### Write a database provider
  - Writing a Database Provider
   - Community standup videos
   - Keeping up-to-date with provider changes
   - Suggested naming of third party providers
   - The EF Core specification tests
    - SQL assertions
     - Inspecting SQL assertion failures
     - Bulk update of baselines

### Provider-impacting changes
  - Provider-impacting changes
   - 2.2 ---> 3.x
   - 2.1 ---> 2.2
    - Test-only changes
    - Test and product code changes

## Tools & extensions
  - EF Core Tools & Extensions
   - Tools
    - EF Core Power Tools
    - EF Core Power Tools CLI
    - LLBLGen Pro
    - Devart Entity Developer
    - DevMagic EF Core Sidekick
    - Entity Framework Visual Editor
    - IWAPI
    - efmig
    - EFCore.Visualizer
   - Extensions
    - Microsoft.EntityFrameworkCore.AutoHistory
    - EFCoreSecondLevelCacheInterceptor
    - EntityFrameworkCore.Scaffolding.Handlebars
    - NeinLinq.EntityFrameworkCore
    - EFCore.BulkExtensions
    - Bricelam.EntityFrameworkCore.Pluralizer
    - Verify.EntityFramework
    - LocalDb
    - EntityFrameworkCore.Projectables
    - EntityFrameworkCore.Triggered
    - Entity Framework Plus
    - Entity Framework Extensions
    - Expressionify
    - EntityLinq
    - EFCore.NamingConventions
    - EFCore.CheckConstraints
    - SimplerSoftware.EntityFrameworkCore.SqlServer.NodaTime
    - EntityFrameworkCore.SqlServer.HierarchyId
    - linq2db.EntityFrameworkCore
    - EFCore.SoftDelete
    - EntityFrameworkCore.ConfigurationManager
    - Detached Mapper
    - EntityFrameworkCore.Sqlite.NodaTime
    - ErikEJ.EntityFrameworkCore.SqlServer.Dacpac
    - ErikEJ.EntityFrameworkCore.DgmlBuilder
    - ErikEJ.EntityFrameworkCore.SqlServer.SqlQuery
    - ErikEJ.EntityFrameworkCore.SqlServer.DateOnlyTimeOnly
    - EntityFramework.Exceptions
    - EntityFrameworkCore.FSharp
    - EntityFrameworkCore.VisualBasic
    - Krzysztofz01.EFCore.QueryFilterBuilder
    - Pagination.EntityFrameworkCore.Extensions
    - Laraue.EfCoreTriggers
    - EntityCloner.Microsoft.EntityFrameworkCore
    - Zomp EF Core Extensions
    - Ainoraz.EFCore.IncludeBuilder
    - Entity Framework Ruler
    - LessCode.EFCore.StronglyTypedId
    - Microsoft.EntityFrameworkCore.DynamicLinq
    - EfCoreNexus.Framework
    - Reconciler
   - API Integrations
    - HotChocolate
    - GraphQL.EntityFramework
    - EntityGraphQL
    - OData
   - Extensions for unsupported EF Core versions
    - nHydrate ORM for Entity Framework
    - Microsoft.EntityFrameworkCore.UnitOfWork
    - Toolbelt.EntityFrameworkCore.IndexAttribute
    - EfCoreTemporalTable
    - EntityFrameworkCore.TemporalTables
    - Dabble.EntityFrameworkCore.Temporal.Query
    - EntityFrameworkCore.NCache
    - Ramses

## Command-line reference
### Overview
  - Entity Framework Core tools reference
   - Next steps

### Package Manager Console (Visual Studio)
  - Entity Framework Core tools reference - Package Manager Console in Visual Studio
   - Installing the tools
    - Verify the installation
   - Using the tools
    - Target and startup project
    - Other target frameworks
    - ASP.NET Core environment
   - Common parameters
   - Add-Migration
   - Bundle-Migration
   - Drop-Database
   - Get-DbContext
   - Get-Migration
   - Optimize-DbContext
   - Remove-Migration
   - Scaffold-DbContext
   - Script-DbContext
   - Script-Migration
   - Update-Database
   - Additional resources

### .NET Core CLI
  - Entity Framework Core tools reference - .NET Core CLI
   - Installing the tools
    - Verify installation
   - Update the tools
   - Using the tools
    - Target project and startup project
    - Other target frameworks
    - ASP.NET Core environment
   - Common options
   - `dotnet ef database drop`
   - `dotnet ef database update`
   - `dotnet ef dbcontext info`
   - `dotnet ef dbcontext list`
   - `dotnet ef dbcontext optimize`
   - `dotnet ef dbcontext scaffold`
   - `dotnet ef dbcontext script`
   - `dotnet ef migrations add`
   - `dotnet ef migrations bundle`
   - `dotnet ef migrations has-pending-model-changes`
   - `dotnet ef migrations list`
   - `dotnet ef migrations remove`
   - `dotnet ef migrations script`
   - Additional resources

### Design-time DbContext creation
  - Design-time DbContext Creation
   - From application services
   - Using a constructor with no parameters
   - From a design-time factory
   - Args
    - [.NET Core CLI](#tab/dotnet-core-cli)
    - [Visual Studio](#tab/vs)

### Design-time services
  - Design-time services
   - Referencing Microsoft.EntityFrameworkCore.Design
   - List of services
   - Using services

## Learn more
#### EF Core API reference >>
          -  [https://learn.microsoft.com/en-us/dotnet/api/?view=efcore-7.0&preserve-view=true]
#### .NET Data Community Standups
  - .NET Data Community Standups
   - Summary
   - 2024
    - Apr 17: [All about EF Core property mapping](https://www.youtube.com/live/ouGIWUtzxRQ?si=qtZ1xqKjKe_E1MhI)
    - Mar 20: [Building Distributed Applications with Hot Chocolate 14, Aspire, and Entity Framework](https://www.youtube.com/live/JjT9pg6oGsE?si=jFykuE06ZFeHGEDJ)
    - Mar 6: [EF Core keys and value generation](https://www.youtube.com/live/_eNPkrTuLvE?si=RuZUFoLqF2QnwbvF)
    - February 21: [Window and binary functions using Zomp EF Core extensions](https://www.youtube.com/live/Z9SkvUuU9Sc?si=xX3rRG3Xr3R9Zj5o)
    - February 7: [Database concurrency and EF Core: Beyond optimistic concurrency](https://www.youtube.com/live/0eVTR5up2RY?si=pttR5NJ85_NWozhj)
    - January 24: [Database concurrency and EF Core: ASP.NET and Blazor](https://www.youtube.com/live/xVyYrtetDeA?si=Bx2s44mk_ayUnAzx)
    - January 10: [Database concurrency and EF Core](https://www.youtube.com/live/YfIM-gfJe4c?si=ZQNxpGEULZt3L43I)
   - 2023
    - November 29: [A tour of what's new in EF8](https://www.youtube.com/live/5HapqzoxJ60?si=DXxh9jo8X16-rETm)
    - October 18: [Introducing the MongoDB provider for EF Core](https://www.youtube.com/live/Zat-ferrjro?si=UKIgjsB5RpnEqJUo)
    - October 4: [Size doesn't matter: Smaller features in EF8](https://www.youtube.com/live/GGDv_p4LAL8?si=WfswHDLiYnMMe4Hm)
    - September 20: [Complex types as value objects in EF8](https://www.youtube.com/live/H-soJYqWSds?si=tJzm-uqLL0ZJnsUh)
    - June 14: [Synchronizing data between the cloud and the client (using SQLite)](https://www.youtube.com/live/QTvFiiST-r4?si=9SOUVhwz75VplWad)
    - May 31: [New CLI edition of EF Core Power Tools](https://www.youtube.com/live/vGvBAoP3nVY?si=VhwBYYdc0F3OSgOu)
    - May 17: [Collections of primitive values in EF Core](https://www.youtube.com/live/AUS2OZjsA2I?si=V8hR14VyBtHuvbmp)
    - Apr 19: [EF Core Internals – Model Building](https://www.youtube.com/live/FYz0rAxQkC8?si=GsLuBBByuQbMurYP)
    - Mar 22: [Using hierarchical data in SQL Server and PostgreSQL with EF Core](https://www.youtube.com/live/pmnHGWYpCfg?si=h_v40tZ7NEw_wZ6W)
    - Mar 8: [EF Core internals: IQueryable, LINQ and the EF Core query pipeline](https://www.youtube.com/live/1Ld3dtnTrMw?si=xWhbADioxqquACBi)
    - Feb 22: [MySQL and .NET: MySqlConnector and the Pomelo EF Core Provider](https://www.youtube.com/live/XSEYNocnzlI?si=WdBnhu_kDewO1TbN)
    - Feb 8: [SQLite with .NET and EF Core](https://www.youtube.com/live/n3Tt0F4g4is?si=aKzl5sr13mSo8DkC)
    - Jan 11: [Entity Framework Core FAQs](https://www.youtube.com/live/2MZNbPT8Q2E?si=TvG40n04AanO9vxj)
   - 2022
    - Dec 14: [The Plan for Entity Framework Core 8](https://www.youtube.com/live/-zoXAeDfNBY?si=Pr6ucas7j58gIyql)
    - Nov 16: [A Whirlwind Tour of EF7](https://www.youtube.com/live/FAQH1H9K6ng?si=tVAkyQSE2mrXX7nO)
    - Nov 7: [EF7 Custom Model Conventions](https://www.youtube.com/live/6apfe1L1FhY?si=g6NuYVtFmLCy9a6i)
    - Oct 19: [New EF Core 7.0 APIs (Bulk Update)](https://www.youtube.com/live/rrKhbiXydKs?si=S5nUIdSerRg8Vqtp)
    - Oct 5: [JSON Columns](https://www.youtube.com/live/0W2vcYMoJ8g?si=NKwrjgz569kQHM_J)
    - Sep 21: [Azure Mobile Apps and offline sync](https://www.youtube.com/live/FbV4VWf7PfQ?si=x2arUB7YLRS79d3E)
    - Aug 24: [New aggregate function support in EF Core 7](https://www.youtube.com/live/IfaURw5D1Qg?si=DbxZ6xflfnds9CN0)
    - Aug 10: [CoreWCF: Roadmap and Q&A](https://www.youtube.com/live/OvaYdycmb-U?si=ucnqZXAoXDSCMZqE)
    - Jul 27: [DbDataSource, a new System.Data abstraction](https://www.youtube.com/live/vRUtHeUpU44?si=jm73JkMidEcZHJZj)
    - Jul 13: [Intercept this EF7 Preview 6 Event](https://www.youtube.com/live/EJs3sSetr2Q?si=V-NxDGrPLPAsV-3f)
    - Jun 29: [DbContext Configuration and Lifetime - EF Core Architecture Part 2](https://www.youtube.com/live/NPgFlqXPbK8?si=k1HbnuniXaivGlAS)
    - Jun 15: [TPH, TPT, and TPC Inheritance mapping with EF Core](https://www.youtube.com/live/HaL6DKW1mrg?si=s82taQNe2QUlZHOA)
    - Jun 1: [EF Core Architecture: Internal Dependency Injection](https://www.youtube.com/live/pYhe-Mt0HzI?si=SF8S0NSQnpTS4zBO)
    - May 18: [Testing EF Core Apps (part 2)](https://www.youtube.com/live/4JQUJk8muCc?si=U81q0c5gEwdpe-dN)
    - May 4: [Database Pagination](https://www.youtube.com/live/DIKH-q-gJNU?si=0TuIPGEEI25ve4i9)
    - Apr 20: [Performance Improvements to the EF7 Update Pipeline](https://www.youtube.com/live/EXbuRVqxn2o?si=tL_J_GCbMi1fFPrb)
    - Apr 6: [Database-first with T4 Templates in EF7: Early look](https://www.youtube.com/live/x2nh1vZBsHE?si=JA7iA1PoiDid5lzm)
    - Mar 9: [GraphQL and OData: An In-Depth Discussion](https://www.youtube.com/live/t7nkdORzed4?si=-2ov3X6DfuhVokWT)
    - Feb 23: [Celebrating 20 Years of .NET: Entity Framework](https://www.youtube.com/live/kiPHP0KuSzM?si=IbVA62S4yn57meAF)
    - Feb 9: [Software version and "stuff"](https://www.youtube.com/live/Os7Rpm3LBkE?si=g9uwjlSvNdAYVatk)
    - Jan 26: [Testing EF Core Apps](https://www.youtube.com/live/KO2aFuLqGkc?si=ivF7Ma9vIEplxaKW)
    - Jan 12: [The EF7 Plan](https://www.youtube.com/live/nU-mtUtbHV4?si=j5YTFfxudv0DOIPh)
   - 2021
    - Dec 1: [Hot Chocolate 12 and GraphQL 2021](https://www.youtube.com/live/3_4nt2QQSeE?si=WT7ecz52hz-SP4Rr)
    - Nov 17: [Make History and Explore the Cosmos, an EF Core 6 Retrospective](https://www.youtube.com/live/cx6IUURncgk?si=CqKbnHztzd-Pv91l)
    - Nov 3: [Noda Time](https://www.youtube.com/live/ZLJLfImuFqM?si=bv_mbh2qzAeICfFG)
    - Oct 6: [SQL Server Temporal Tables and EF Core 6](https://www.youtube.com/live/2aCgKM41NFw?si=q__izjX1qL0GHyqe)
    - Oct 20: [EF Core and ASP.NET Core from the ASP.NET documentation team](https://www.youtube.com/live/2wdJ0xjGF2o?si=V7pOPwty_8Oi1i36)
    - Sep 22: [PostgreSQL and EF Core](https://www.youtube.com/live/Ya_cmZRwACM?si=FSx9ajf5fXrwz5t7)
    - Aug 25: [Dapper](https://www.youtube.com/live/txiQar6PqvA?si=wIEFckHrk2RD2z4z)
    - Aug 11: [EF Core's Global Query Filter](https://www.youtube.com/live/Uy0c_DKGM-U?si=5iLoEM8ZdKjXXjdY)
    - Jul 28: [OData](https://www.youtube.com/live/Q3Ove-2Uh94?si=VPRzsiqO-S9nD5bs)
    - Jul 14: [Visualizing database query plans](https://www.youtube.com/live/Zhy5antRDJk?si=avlq-ll147UyRcIt)
    - Jun 16: [Azure Cosmos DB and EF Core](https://www.youtube.com/live/nEqH_XfCfho?si=rq5L2ciDW37atihz)
    - Jun 2: [Introducing EF Core Compiled Models](https://www.youtube.com/live/XdhX3iLXAPk?si=DzUmXMMLWFh8XSXv)
    - May 19: [Building Modern Apps with GraphQL](https://www.youtube.com/live/4k3WzW2ZdXs?si=DXqIxVNNlbMILNeT)
    - May 5: [Triggers for EF Core](https://www.youtube.com/live/Gjys0Yebobk?si=JcRRypyCPZxjho0k)
    - Apr 21: [Open Source Contributions: How to Add a Feature to EF Core](https://www.youtube.com/live/9OMxy1wal1s?si=WSH5zxI8L23WLoy7)
    - Apr 7: [Azure SQL for Cloud-Born Applications and Developers](https://www.youtube.com/live/GhIhwCafilk?si=gyyq5PgHv-qf8UV0)
    - Mar 24: [EF Core Power Tools: the New Batch](https://www.youtube.com/live/3-Izu_qLDqY?si=Tx1Cbwvtq_GI_dmG)
    - Mar 10: [Julie Lerman and EF Core Ask Me Anything (AMA)](https://www.youtube.com/live/oZVsZrFKp48?si=OqUUNoea5R5ds5rg)
    - Feb 24: [Performance Tuning an EF Core App](https://www.youtube.com/live/VgNFFEqwZPU?si=3XQwMvO5kWMemi7T)
    - Feb 10: [Typed Exceptions for Entity Framework Core](https://www.youtube.com/live/aUl5QfswNU4?si=zbglNkNEElISaVpb)
    - Jan 27: [Introducing MSBuild.Sdk.SqlProj](https://www.youtube.com/live/lmHU1zD2mvA?si=75sWlZjkLDbakuzG)
    - Jan 13: [EF Core 6.0 Survey Results](https://www.youtube.com/live/IiAS61uVDqE?si=EPu3HUNiThsWm88f)
   - 2020
    - Dec 2: [LLBLGen designer and .NET data history](https://www.youtube.com/live/notUk3yR0mc?si=mUHTlgHjXwCxAW1Z)
    - Nov 18: [Special EF Core 5.0 Community Panel](https://www.youtube.com/live/AkqRn2vr1lc?si=uAgpUza2w2k6HChb)
    - Oct 28: [EF Core 5.0 Collations](https://www.youtube.com/live/OgMhLVa_VfA?si=bhjMpN1l_N9RYYYN)
    - Oct 14: [Cosmos DB: Repository Pattern .NET Wrapper SDK](https://www.youtube.com/live/Ejbgqq8vETM?si=kyCTJenwpGqQVtFC)
    - Sep 30: [Geographic Data with NetTopologySuite](https://www.youtube.com/live/IHslY5rrxD0?si=QpNNSZql1UsydmHz)
    - Sep 16: [What's New with Migrations in EF Core 5.0](https://www.youtube.com/live/mSsGERmrhnE?si=mw1jCDxDbERDrfAi)
    - Sep 2: [Sync your database with DotMim.Sync](https://www.youtube.com/live/_SHryJiblRo?si=rmlPMxFWPRYHXDvX)
    - Aug 19: [Many-to-Many in EF Core 5.0](https://www.youtube.com/live/W1sxepfIMRM?si=JSBiCbeA3jM0tSz8)
    - Aug 5: [EF Core In Depth Video Series](https://www.youtube.com/live/b-zTazj2vuI?si=A9lCvvHva3AomWe7)
    - Jul 22: [Using Scaffolding with Handlebars](https://www.youtube.com/live/6Ux7EpgiWXE?si=78XhoFrViXVkMXOL)
    - Jun 24: [EF Core in Blazor](https://www.youtube.com/live/HNJYIqeBLQc?si=xvEObLRdY37_0L87)
    - Jun 10: [EF Core Power Tools](https://www.youtube.com/live/OWuP_qOYwsk?si=VoSGWW6CfR8-x46P)
    - May 6: [Introducing the EF Core Community Standup](https://www.youtube.com/live/j1sGgfCxhp0?si=VQBMex-9-me9JhAB)

[^1]: Важный вопрос- обработки ошибок
[^2]: транзакции