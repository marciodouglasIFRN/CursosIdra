import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cartao',
  templateUrl: './cartao.component.html',
  styleUrls: ['./cartao.component.css']
})
export class CartaoComponent {

  public baseUrl: string;
  public http: HttpClient;
  public cartao: Cartao;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
    this.http = http;
  }

  public cadastra() {
    // this.http.post(this.baseUrl + 'cartao',{});
    const options = {responseType: 'text' as 'json'};
    this.http.post<Cartao>(this.baseUrl + 'cartao', { title: 'Angular POST Request Example' },options)
    .subscribe(result => {
      this.cartao = result;
    }, error => console.error(error));
  }

}

interface Cartao {
  id: number;
  titular: string;
  numero: string;
  vencimento: string;
  codigoVerificacao: string;
}
