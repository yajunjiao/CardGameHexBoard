﻿using System;
using System.Collections;
using System.Collections.Generic;
using HexCardGame;
using HexCardGame.Model.GameBoard;
using UnityEngine;
using UnityEngine.Tilemaps;
using Logger = Tools.Logger;

namespace Game.Ui
{
    public class UiBoard : UiEventListener, ICreateBoard
    {
        [SerializeField] TileBase test;
        Board CurrentBoard { get; set; }
        Tilemap TileMap { get; set; }

        protected override void Awake()
        {
            base.Awake();
            TileMap = GetComponentInChildren<Tilemap>();
        }

        void ICreateBoard.OnCreateBoard(Board board)
        {
            CurrentBoard = board;
            Logger.Log<UiBoard>("Board View Created");
            foreach(var p in board.Units)
                TileMap.SetTile(p, test);
        }
    }
}