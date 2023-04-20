import {
  Entity,
  Column,
  PrimaryGeneratedColumn,
} from "typeorm";

@Entity()
export class User {
  @PrimaryGeneratedColumn()
  id: number;
  
  @Column()
  UserId: number;

  @Column()
  UserName: string;

  @Column()
  UserAge: number;

  @Column()
  UserPresent: string;

}
