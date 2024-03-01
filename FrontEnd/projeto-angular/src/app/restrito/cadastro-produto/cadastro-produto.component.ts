import { Component } from '@angular/core';
import { Produto } from '../../models/Produto.model';
import { Router } from '@angular/router';
import { ProdutoService } from '../../produto.service';

@Component({
  selector: 'app-cadastro-produto',
  templateUrl: './cadastro-produto.component.html',
  styleUrl: './cadastro-produto.component.css'
})
export class CadastroProdutoComponent {

  public produto: Produto = new Produto(0, "", "", "", 0);

  constructor(private _produtoService: ProdutoService, private _router: Router){}

  cadastrar():void {
    this._produtoService.cadastrarProduto(this.produto).subscribe(
      produto => {
        this.produto = new Produto(0, "", "", "", 0);
        alert("Cadastro efetuado com sucesso");
      },
      err => {
        alert("Erro ao cadastrar")
      }
    );
    this._router.navigate(["restrito/lista"])
  }

}
