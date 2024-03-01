import { Component, OnInit } from '@angular/core';
import { Produto } from '../../models/Produto.model';
import { ActivatedRoute, Router } from '@angular/router';
import { ProdutoService } from '../../produto.service';

@Component({
  selector: 'app-atualiza-produto',
  templateUrl: './atualiza-produto.component.html',
  styleUrl: './atualiza-produto.component.css'
})
export class AtualizaProdutoComponent implements OnInit{

  public productId: number = 0;
  public produto: Produto = new Produto(0, "", "", "", 0);

  constructor(private _produtoService: ProdutoService, private _router: Router,
              private _activateRoute:ActivatedRoute){
    this._activateRoute.params.subscribe(params => this.productId = params['id']);
  }

  ngOnInit(): void {
      this.listarProduto();
  }

  listarProduto():void {
    this._produtoService.getProduto(this.productId).subscribe(
      (res: any) => {
        this.produto = new Produto(
          res[0].id,
          res[0].produto,
          res[0].descricao,
          res[0].foto,
          res[0].preco
        )
      }
    )
  }

  atualizar(id: number) {
    this._produtoService.atualizaProduto(id, this.produto).subscribe(
      produto => {this.produto = new Produto(0, "", "", "", 0)},
      err => {alert("Erro ao atualizar")}
    );
    this._router.navigate(["/restrito/lista"])
  }

}
