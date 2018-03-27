import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: 'htmlfiles/app.component.html',
  styleUrls: ['cssfiles/component.css','/cssfiles/image_mask.css'],
  
})
export class AppComponent {
  title = 'andrea santi photographer';

  constructor( private router: Router){}

  getContacts():void{
    this.router.navigate(['contacts']);
  }
}
