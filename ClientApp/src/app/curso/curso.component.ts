import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-curso',
  templateUrl: './curso.component.html',
  styleUrls: ['./curso.component.css']
})
export class CursoComponent {
  public cursos: Curso[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'curso').subscribe(result => {
      console.log(result);
      this.cursos = result;
    }, error => console.error(error));
  }

}

interface Curso {
  id: number;
  nome: string;
}
