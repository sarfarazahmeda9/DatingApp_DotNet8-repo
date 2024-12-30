import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { inject } from '@angular/core';

//imports: [RouterOutlet, NgFor],
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  
  title = 'DatingApp';
  http = inject(HttpClient);
  users : any

  ngOnInit(): void {
    this.http.get('http://localhost:5001/api/users').subscribe
    ( {
        next : (response: any) => this.users = response, 
        error : (error: any) => console.log(error),
        complete : () => console.log('complete')
     }  
    )
  }
}

