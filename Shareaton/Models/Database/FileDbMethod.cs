using Shareaton.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Shareaton.Models.Database
{
    public class FileDbMethod : IDbMethod<File>
    {
        public void Delete(File file)
        {
            using (DbAccess db = new DbAccess())
            {
                db.Entry(file).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public File GetOneById(Guid id)
        {
            File file = null;

            using (DbAccess db = new DbAccess())
            {
                file = db.Nodes.AsNoTracking().Include("Parent").Where(x => x.Id.Equals(id)).FirstOrDefault() as File;
            }
            if (file != null)
                return file;
            else
                throw new NodeNotFoundException("The Node specified did not found");
        }

        public void Save(File file)
        {
            using (DbAccess db = new DbAccess())
            {
                db.Entry(file.Parent).State = System.Data.Entity.EntityState.Unchanged;
                db.Nodes.Add(file);
                db.SaveChanges();
            }
        }

        public void SaveAll(IEnumerable<File> files)
        {
            using (DbAccess db = new DbAccess())
            {
                db.Nodes.AddRange(files);
                db.SaveChanges();
            }
        }

        public void SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(File file)
        {
            using (DbAccess db = new DbAccess())
            {
                db.Entry(file).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void UpdateFileAndParent(File file)
        {
            using (DbAccess db = new DbAccess())
            {
                var currentFile = db.Nodes.Include("Parent").Single(c => c.Id.Equals(file.Id));
                DbEntityEntry aa = db.Entry(currentFile);
                aa.CurrentValues.SetValues(file);
                Folder parent = db.Nodes.Include("Parent").Single(c => c.Id.Equals(file.Parent.Id)) as Folder;
                db.Nodes.Attach(parent);
                currentFile.Parent = parent;
                db.SaveChanges();
            }
        }
    }
}