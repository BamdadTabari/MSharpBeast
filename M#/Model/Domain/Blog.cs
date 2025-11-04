using MSharp;
using System.Numerics;

namespace Domain
{
    public class Blog : EntityType
    {
        public Blog()
        {
            DatabaseMode(DatabaseOption.Managed).Schema("dbo").Name("Blog");

            String("Blog title").Mandatory();
            BigString("Blog content").Mandatory();
            Int("View count").Default(cs("0"));
        }
    }
}