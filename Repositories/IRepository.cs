namespace SantasWishlist.Repositories
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Create a new entity
        /// </summary>
        /// <param name="entity">The entity you want to create</param>
        /// <returns>The created entity</returns>
        T Create(T entity);

        /// <summary>
        /// Fetch an entity from the database
        /// </summary>
        /// <param name="id">Id of the entity you want to fetch</param>
        /// <returns>Entity given Id</returns>
        T Read(string id);

        /// <summary>
        /// Fetch all entities from the database
        /// </summary>
        /// <returns>All entities</returns>
        List<T> ReadAll();

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity">New version of the entity</param>
        /// <returns>The new entity</returns>
        T Update(T entity);

        /// <summary>
        /// Delete an entity from the database
        /// </summary>
        /// <param name="id">Id of the entity you want to delete</param>
        void Delete(string id);

    }
}
