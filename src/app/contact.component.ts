
import { Component,OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { RouterModule, Routes,Router,ActivatedRoute } from '@angular/router';
import { ImageService } from './image.service';
import {Image} from './image';
import {Album} from './album';
import 'rxjs/add/operator/map'
@Component({
  selector: 'contact-viewer',
  templateUrl: 'htmlfiles/contact.component.html',
  styleUrls: ['cssfiles/component.css','cssfiles/image_mask.css'],
  
})

export class ContactComponent{
  title = 'andrea santi photographer';
  
}
