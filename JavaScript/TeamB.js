function Student(name, id, college)
{
    this.name = name;
    this.id = id;
    this.college = college;
    this.getStudentData = function()
    {
        return this.name + " " + this.id + " " + this.college;
    }

}