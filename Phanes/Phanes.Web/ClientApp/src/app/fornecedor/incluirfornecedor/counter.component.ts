import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount;
  public currentHttp;
  public currentBaseUrl;

  constructor(http: HttpClient, @Inject('BASE_API') baseUrl: string) {
    this.currentCount = 5;
    this.currentHttp = http;
    this.currentBaseUrl = baseUrl;
  }


  public incrementCounter() {
    this.post();
    this.currentCount++;
  }
  public post() {
    console.log("Url", this.currentBaseUrl);
    var fornecedor = new Fornecedor("Nome", "Email");
    this.currentHttp.post(this.currentBaseUrl + 'api/SampleData', fornecedor).subscribe(result => {
      console.log("result", result);
    }, error => console.error(error));
  }
}

class Fornecedor {
  nome: string;
  email: string;
  constructor(public nomeFornecedor, public emailFornecedor)
  {
    this.nome = nomeFornecedor;
    this.email = emailFornecedor;
  }
}
