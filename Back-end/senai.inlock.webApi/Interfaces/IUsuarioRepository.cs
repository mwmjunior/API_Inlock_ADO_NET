﻿using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioDomain Login(string Email, string Senha);
    }
}
