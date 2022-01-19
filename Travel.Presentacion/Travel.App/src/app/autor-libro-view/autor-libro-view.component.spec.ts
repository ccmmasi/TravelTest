import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AutorLibroViewComponent } from './autor-libro-view.component';

describe('AutorLibroViewComponent', () => {
  let component: AutorLibroViewComponent;
  let fixture: ComponentFixture<AutorLibroViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AutorLibroViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AutorLibroViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
