import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-evento',
  templateUrl: './evento.component.html',
  styleUrls: ['./evento.component.css']
})
export class EventoComponent implements OnInit {

  public eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): any{

    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)

    );
  }
}
