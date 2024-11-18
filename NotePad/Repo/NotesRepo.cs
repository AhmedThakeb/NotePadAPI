using NotePad.Data;

namespace NotePad.Repo
{
    public class NotesRepo
    {
        private readonly ApplicationDbContext db;

        public NotesRepo(ApplicationDbContext db)
        {
            this.db = db;
        }

        


    }
}
