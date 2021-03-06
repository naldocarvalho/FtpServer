// <copyright file="TcpSocketClientAccessor.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System.Net.Sockets;

namespace FubarDev.FtpServer
{
    /// <summary>
    /// Accessor to set/get the current <see cref="TcpClient"/>.
    /// </summary>
    public class TcpSocketClientAccessor
    {
        /// <summary>
        /// Gets or sets the current <see cref="TcpClient"/>.
        /// </summary>
        public TcpClient TcpSocketClient { get; set; }
    }
}
