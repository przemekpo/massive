
using System.Linq;
using GraphAssesment.Domain;
using GraphAssesment.Infrastructure.Mongo.Shared;
using MongoDB.Driver;

namespace GraphAssesment.Infrastructure.Mongo.Repositories
{
    //could be extracted to base repository
    public class GraphRepository :  IGraphRepository
    {
       
        private readonly IMongoDatabase _database;
        private readonly string _documentType;

       
        public GraphRepository(IMongoDatabase mongodatabase)
        {
            _documentType = "graph";
            _database = mongodatabase;
          
        }

        protected IMongoCollection<Graph> Collection
        {
            get { return _database.GetCollection<Graph>(_documentType); }
        }

        public Graph GetById(string id)
        {
            return AsyncHelper.RunSync(() => Collection.Find(Builders<Graph>.Filter.Eq(graph => graph.Id, id)).FirstOrDefaultAsync());
        }
        //special method since we 
        public Graph Get()
        {
            return AsyncHelper.RunSync(() => Collection.Find(_=>true).FirstOrDefaultAsync());
        }
        public string Add(Graph graph)
        {
          
            Collection.InsertOneAsync(graph).Wait();
            return graph.Id;
        }

        public void Update(Graph entity)
        {
            var filter = Builders<Graph>.Filter.Where(x => x.Id == entity.Id);

            AsyncHelper.RunSync(() => Collection.ReplaceOneAsync(filter, entity));
        }
    }
}
