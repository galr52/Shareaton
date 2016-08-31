using Shareaton.Data.DAL.Infrastructure;
using Shareaton.Data.DAL.SqlServer;
using Shareaton.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shareaton.Controllers
{
    [RoutePrefix("api/Files")]
    public class FilesController : ApiController
    {
        private NodeRepository filesRepository;

        public FilesController()
        {
            this.filesRepository = new NodeRepository();
        }

        public FilesController(NodeRepository filesRepository)
        {
            this.filesRepository = filesRepository;
        }

        [Route("{folderId:guid}")]
        [HttpGet]
        public IHttpActionResult GetFiles(Guid folderId)
        {
            var files = this.filesRepository.GetAll().ToList();
            return Ok(files);
        }
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetFiles()
        {
            var files = this.filesRepository.GetAll();
            return Ok(files);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Upload(string name)
        {
            this.filesRepository.Add(new File
            {
                Name = name,
                Creation = DateTime.Now
            });

            return Ok();
        }
    }
}
