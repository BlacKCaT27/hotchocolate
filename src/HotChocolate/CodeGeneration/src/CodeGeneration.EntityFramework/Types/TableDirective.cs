using HotChocolate.Types;

namespace HotChocolate.CodeGeneration.EntityFramework.Types
{
    public class TableDirective
    {
        public string? Name { get; set; }
    }

    public class TableDirectiveType : DirectiveType<TableDirective>
    {
        public const string NameConst = "table";

        protected override void Configure(IDirectiveTypeDescriptor<TableDirective> descriptor)
        {
            descriptor
                .Name(NameConst)
                .Location(DirectiveLocation.Object);

            descriptor
                .Argument(t => t.Name)
                .Description(
                    "The name to use for the table in the database schema. " + 
                    "If none is provided, the table name convention will be used.")
                .Type<StringType>();
        }
    }
}
