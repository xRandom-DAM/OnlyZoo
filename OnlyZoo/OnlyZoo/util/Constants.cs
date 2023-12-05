using OnlyZoo.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.util
{
    internal class Constants
    {
        public const string DBString = "server=127.0.0.1;" +
                                        "port=6969;" +
                                        "uid=root;" +
                                        "pwd=OnlyZoo;" +
                                        "database=OnlyZoo";

        public const string TestLogFile = "development/Tests.log";
        public const string ErrorLogFile = "Errors.log";

        // Tablas

        public const string PetTableName = "Pet";
        public const string PetIdColumnName = "Id";
        public const string PetNameColumnName = "Name";
        public const string PetBirthColumnName = "Birth";
        public const string PetDescriptionColumnName = "Description";
        public const string PetBreedColumnName = "Breed";
        public const string PetPictureColumnName = "Picture";

    }
}
