using Debo.Templet.Commons;
using Debo.Templet.DataTransferObject.Views;
using System.Data.Entity.ModelConfiguration;


namespace Debo.Templet.QueryService.EntityFramework.Mappings
{
    public class UserMapping : EntityTypeConfiguration<UserView>
    {
        public UserMapping()
        {
            ToTable(DBTableNames.UserView);
        }
    }
}
