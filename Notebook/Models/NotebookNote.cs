using System;

namespace migueladanrm.Notebook.Models
{
    /// <summary>
    /// Nota.
    /// </summary>
    public class NotebookNote
    {
        protected int number;
        protected string id;
        protected string title;
        protected string note;
        protected DateTime creationDateTime;
        protected DateTime lastModificationDateTime;
        protected DateTime lastAccessDateTime;
        protected string passwordHash;

        public NotebookNote()
        {

        }

        /// <summary>
        /// Número de nota.
        /// </summary>
        public int Number => number;

        /// <summary>
        /// Identificador único.
        /// </summary>
        public string Id => id;

        /// <summary>
        /// Título de la nota.
        /// </summary>
        public string Title {
            get => title;
            set => title = value;
        }

        /// <summary>
        /// Contenido de la nota.
        /// </summary>
        public string Note {
            get => note;
            set => note = value;
        }

        /// <summary>
        /// Fecha y hora de creación.
        /// </summary>
        public DateTime CreationDateTime => creationDateTime;

        /// <summary>
        /// Fecha y hora de último modificación.
        /// </summary>
        public DateTime LastModificationDateTime {
            get => lastModificationDateTime;
            set => lastModificationDateTime = value;
        }

        /// <summary>
        /// Fecha y hora de último acceso.
        /// </summary>
        public DateTime LastAccessDateTime {
            get => lastAccessDateTime;
            set => lastAccessDateTime = value;
        }

        /// <summary>
        /// Hash de la contraseña de la nota (si existe).
        /// </summary>
        public string PasswordHash => passwordHash;

        public void Save()
        {

        }
    }
}