using System;

namespace CoreSchool.Entities
{
    public class Test
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Student Student { get; set; }

        public Signature Signature {get; set; }

        public float Result {get; set; }
        public Test() => UniqueId = Guid.NewGuid().ToString();
    }
}