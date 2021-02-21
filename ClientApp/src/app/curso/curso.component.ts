import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-curso',
  templateUrl: './curso.component.html',
  styleUrls: ['./curso.component.css']
})
export class CursoComponent {
  public cursos: Curso[];
  public testo: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Curso[]>(baseUrl + 'curso').subscribe(result => {
      this.cursos = result;
      this.testo = "alguma coisa";
    }, error => console.error(error));
  }

}

interface Curso {
  id: number;
  nome: string;
}
