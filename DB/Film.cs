//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaAppLOLGG.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieCategory { get; set; }
        public byte[] PosterPriview { get; set; }
        public string Description { get; set; }
    }
}