using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities.Characters
{
    abstract class Character
    {
        /// <summary>
        /// Name of a character.
        /// </summary>
        protected string Name { get; set; }
        protected bool DefaultValuesSet { get; set; }
    }
}
