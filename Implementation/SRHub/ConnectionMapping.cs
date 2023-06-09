﻿using System.Collections.Concurrent;

namespace ProjectNetworkMediaApi.SRHub
{
    public class ConnectionMapping
    {
        private static readonly ConcurrentDictionary<string, UserConnection> _connections =
            new ConcurrentDictionary<string, UserConnection>();

        public void Add(UserConnection connection)
        {
            var previous = _connections.Where(x => x.Key == connection.UserId);

            foreach(var p in previous)
            {
                _connections.TryRemove(p);
            }

            _connections.TryAdd(connection.UserId, connection);
        }

        public void Remove(UserConnection connection)
        {
            _connections.TryRemove(connection.UserId, out var _);
        }

        public string GetConnectionForUser(string userId)
        {
            return _connections.TryGetValue(userId, out var connection) ? connection.ConnectionId : null;
        }
    }

}
